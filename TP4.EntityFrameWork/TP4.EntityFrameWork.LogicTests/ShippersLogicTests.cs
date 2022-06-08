using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP4.EntityFrameWork.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.EntityFrameWork.Data;
using TP4.EntityFrameWork.Entities;

namespace TP4.EntityFrameWork.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {

        [TestMethod()]
        public void AddTest()
        {
            // arrange
            ShippersLogic shippersLogic = new ShippersLogic();  //Instancio
            Shippers shipperAdd = new Shippers();
            shipperAdd.CompanyName = "UnitTest";  //Agrego campos
            shipperAdd.Phone = "UnitTest";

            // act
            shippersLogic.Add(shipperAdd);  //a utilizar como resultado esperado

            // assert
            List<Shippers> newList = shippersLogic.GetAll().ToList();  //obtengo lista actualizada
            Shippers checkList = newList[newList.Count() - 1];  //chequeo con la lista actualizada
            Assert.AreEqual(shipperAdd, checkList);  //compruebo
        }
    }
}