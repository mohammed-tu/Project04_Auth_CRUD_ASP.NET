﻿using Final_Project.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ProjectTest.Controllers
{

    [TestFixture]
    class LessorsControllerTest
    {
        [Test]
        public void Index1_isNull()
        {
            //Arrange
            LessorsController plases = new LessorsController();
            //Act
            ViewResult viewResult = plases.Index1() as ViewResult;
            //Assert
            Assert.IsNull(viewResult.ViewName);
        }

    }
}