﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESOPDirectAssignment;
using ESOPDirectAssignment.Controllers;
using ESOPDirectAssignment.Calculator;

namespace ESOPDirectAssignment.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ZeroFactorialIsOne()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            float result = calculator.GetFactorial(0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OneFactorialIsOne()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            float result = calculator.GetFactorial(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TwoFactorialIsTwo()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            float result = calculator.GetFactorial(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ThreeFactorialIsSix()
        {
            FactorialCalculator calculator = new FactorialCalculator();
            float result = calculator.GetFactorial(3);

            Assert.AreEqual(6, result);
        }
    }
}
