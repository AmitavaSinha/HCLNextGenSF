using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ServiceFabric.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace Order.Test
{
    public class OrderTest
    {
        [TestFixture]
        public class VotingTest
        {
            [Test]
            public async Task PutTest()
            {

                MockReliableStateManager stateManager = new MockReliableStateManager();
                OrderData.Controllers.VoteDataController target = new OrderData.Controllers.VoteDataController(stateManager);
                //var actual = await target.Get();
                IActionResult result = await target.Put("Cricket");
                var okResult = result as OkResult;
                //Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
                Assert.AreEqual("2", "2");
            }
        }
    }
}
