using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime date = new DateTime(2022, 07, 24);
      Order newOrder = new Order("Chocolate", 4, "Donut Order", date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
        [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Donut";
      double price = 4;
      string title = "Donut Order";
      DateTime date = new DateTime(2022, 07, 24);
      Order newOrder = new Order(description, price, title, date);

      //Act
      string updatedDescription = "Do the dishes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
  }
}