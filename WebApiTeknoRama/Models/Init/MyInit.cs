using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApiTeknoRama.Models.Entities;
using WebApiTeknoRama.Models.Context;

namespace WebApiTeknoRama.Models.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {

        protected override void Seed(MyContext context)
        {
            CardInfo ci = new CardInfo();
            ci.CardUserName = "";
            ci.CardNumber = "";
            ci.CardExpiryYear = "";
            ci.CardExpiryMonth = "";
            ci.SecuriyNumber = "";
            ci.Limit = 1000;
            ci.Balance = 1000;
            context.Cards.Add(ci);
            context.SaveChanges();
        }
    }
}