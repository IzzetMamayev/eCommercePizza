using eCommercePizza.Entities;
using eCommercePizza.Repositories.Interfaces;
using eCommercePizza.Repositories.Models;
using eCommercePizza.Services.Implementations;
using eCommercePizza.Services.Interfaces;
using eCommercePizza.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Razorpay.Api;
using System;
using webUI.Helpers;
using webUI.Interfaces;
using webUI.Models;

namespace webUI.Controllers
{
       //    key_id key_secret
       //    rzp_test_XRvTFD3oTjOqGA m4pf9ivWOuV7965mGOG9aNPG
       //    5104 0600 0000 0008
       //    4111 1111 1111 1111

    public class PaymentController : BaseController
    {
        private readonly IOptions<RazorPayConfig> _razorPayConfig;
        private readonly IPaymentService _paymentService;
        private IUserAccessor _userAccessor;
        public PaymentController(IOptions<RazorPayConfig> razorPayConfig,
            IPaymentService paymentService, IUserAccessor userAccessor) : base(userAccessor)
        {
            _razorPayConfig = razorPayConfig;
            _paymentService = paymentService;
            _userAccessor = userAccessor;
        }
        public IActionResult Index()
        {
            PaymentModel payment = new PaymentModel();

            CartModel cart = TempData.Peek<CartModel>("Cart");
            if (cart != null)
            {
                payment.Cart = cart;
            }

            payment.GrandTotal = Math.Round(cart.GrandTotal);
            payment.Currency = "USD";
            string items = "";
            foreach (var item in cart.Items)
            {
                items += item.Name + ",";
            }
            payment.Description = items;
            payment.RazorpayKey = _razorPayConfig.Value.Key;
            payment.Receipt = Guid.NewGuid().ToString();

            // nedd to creating order first
            payment.OrderId = _paymentService.CreateOrder(payment.GrandTotal * 100, payment.Currency, payment.Receipt);

            return View(payment);
        }


        [HttpPost]
        public IActionResult Status(IFormCollection form)
        {
            try
            {
                if (form.Keys.Count > 0 && !String.IsNullOrWhiteSpace(form["rzp_paymentid"]))
                {
                    string paymentId = form["rzp_paymentid"];
                    string orderId = form["rzp_orderid"];
                    string signature = form["rzp_signature"];
                    string transactionId = form["Receipt"];
                    string currency = form["Currency"];

                    var payment = _paymentService.GetPaymentDetails(paymentId);
                    bool IsSignVerified = _paymentService.VerifySignature(signature, orderId, paymentId);

                    if (IsSignVerified && payment != null)
                    {
                        CartModel cart = TempData.Get<CartModel>("Cart");
                        PaymentDetails model = new PaymentDetails();

                        model.CartId = cart.Id;
                        model.Total = cart.Total;
                        model.Tax = cart.Tax;
                        model.GrandTotal = cart.GrandTotal;

                        model.Status = payment.Attributes["status"]; //captured
                        model.TransactionId = transactionId;
                        model.Currency = payment.Attributes["currency"];
                        model.Email = payment.Attributes["email"];
                        model.Id = paymentId;
                        model.UserId = CurrentUser.Id;

                        int status = _paymentService.SavePaymentDetails(model);
                        if (status > 0)
                        {
                            Response.Cookies.Append("CId", ""); //resettingg cartId in cookie

                            Address address = TempData.Get<Address>("Address");
                            //_orderService.PlaceOrder(CurrentUser.Id, orderId, paymentId, cart, address);

                            //TO DO: Send email
                            TempData.Set("PaymentDetails", model);
                            return RedirectToAction("Receipt");
                        }
                        else
                        {
                            ViewBag.Message = "Although, due to some technical issues it's not get updated in our side. We will contact you soon..";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            ViewBag.Message = "Your payment has been failed. You can contact us at izzetmamaev@mail.com";
            return View();
        }

        public IActionResult Receipt()
        {
            PaymentDetails model = TempData.Peek<PaymentDetails>("PaymentDetails");
            return View(model);
        }
    }
}
