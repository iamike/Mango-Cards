using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mango_Cards.Library.Models;
using System.Collections.Generic;
using Mango_Cards.Library.Models.Enum;

namespace MangoCards.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new MangoCardsDataContext();
            //初始化
            var ben = new Employee { Id = Guid.NewGuid(), Name = "Ben", Gender = Gender.男 };
            var mike = new Employee { Id = Guid.NewGuid(), Name = "Mike", Gender = Gender.男 };
            var cardTy1 = new CardType
            {
                Id=Guid.NewGuid(),
                Name="请帖",

            };
            var cardTy3 = new CardType
            {
                Id = Guid.NewGuid(),
                Name = "海报",

            };
            var cardTy2 = new CardType
            {
                Id = Guid.NewGuid(),
                Name = "婚礼",
                Parent = cardTy1,
                CardDemos = new List<CardDemo> { new CardDemo {
                    Id=Guid.NewGuid(),
                    Name="婚礼1",
                    Employee=mike,
                },new CardDemo { Id=Guid.NewGuid(),
                    Name="婚礼2",
                    Employee=ben
                } }
            };
            db.Employees.Add(ben);
            db.Employees.Add(mike);
            db.SaveChanges();
        }
    }
}
