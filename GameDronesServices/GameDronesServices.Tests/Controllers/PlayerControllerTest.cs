using GameDronesServices.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using GameDronesServices.Models;
using GameDronesServices.Repositories;
using System.Web.Http.Results;
using System.Diagnostics;
using System.Web.Http;

namespace GameDronesServices.Tests.Controllers
{
    [TestClass]
    public class PlayerControllerTest
    {
        [TestMethod]
        public void GetShouldReturnPlayerList()
        {
            var moqRepository = new Mock<IRepositoryBase<Player>>();

            var controller = new PlayerController(moqRepository.Object);

            IEnumerable<Player> players = controller.Get();

            Assert.IsNotNull(players);
        }

        [TestMethod]
        public void PostShouldSavePlayer()
        {
            Player player = new Player() { Username = "AryaStark" };

            var moqRepository = new Mock<IRepositoryBase<Player>>();
            var controller = new PlayerController(moqRepository.Object);

            IHttpActionResult actionResult = controller.Post(player);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Player>;

            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }
    }
}
