using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiTeknoRama.DesignPatterns.SingletonPattern;
using WebApiTeknoRama.Models.Context;
using WebApiTeknoRama.Models.Entities;
using WebApiTeknoRama.DTOClasses;
using System.Data.Entity.Core.Metadata.Edm;

namespace WebApiTeknoRama.Controllers
{
    public class PaymentController:ApiController
    {

        MyContext _db;
        public PaymentController()
        {

            _db = DBTool.DBInstance;
            
        }

        [HttpPost]
        public IHttpActionResult ReceivePayment(PaymentDTO item)
        {
            CardInfo ci = _db.Cards.FirstOrDefault(x => x.CardNumber == item.CardNumber && x.SecuriyNumber == item.SecurityNumber && x.CardUserName == item.CardNumber && x.CardExpiryYear == item.CardExpiryYear &&
            x.CardExpiryMonth == item.CardExpiryMonth);

            if (ci != null)
            {
                if (ci.CardExpiryYear < DateTime.Now.Year)
                {
                    return BadRequest("Expired Year");
                }
                else if (ci.CardExpiryYear == DateTime.Now.Year)
                {
                    if (ci.CardExpiryMonth < DateTime.Now.Month)
                    {
                        return BadRequest("Expired Card");
                    }

                    if (ci.Balance >= item.ShoppingPrice)
                    {
                        SetBalance(item, ci);
                        return Ok();
                    }
                    else
                    {
                        return BadRequest("Balance is not enough");
                    }
                }
                else if (ci.Balance >= item.ShoppingPrice)
                {
                    SetBalance(item, ci);
                    return Ok();
                }
                return BadRequest("Balance is not Okay");
            }
            return BadRequest("Card is not findable");
            
            
            
        
                


            
        }

        void SetBalance(PaymentDTO item, CardInfo ci)
        {
            ci.Balance -= item.ShoppingPrice;
            _db.SaveChanges();
        }
    }
}