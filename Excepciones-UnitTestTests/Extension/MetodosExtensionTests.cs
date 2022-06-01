using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_UnitTest.Tests
{
    [TestClass()]
    public class MetodosExtensionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))] //Especifico que espero la excepcion de dividir por cero
        public void DivisionPorCeroSimpleTest()
        {
            //Arrange
            int numero = 10;

            //Act
            int resultado = numero / 0;
            //Assert ---> en este caso no hace falta agregarlo ya que espero una Excepción
        }

        [TestMethod()]
        public void DividendoYDivisorTest()
        {
            //Arrange
            int numero1 = 20;
            int numero2 = 5;
            int division = numero1 / numero2;

            //Act
            int resultadoEsperado = 4;

            //Assert
            Assert.AreEqual(division,resultadoEsperado);
        }

        [TestMethod()]
        public void DividendoYDivisorTest1()
        {
            //Arrange
            int numero1 = 20;
            int numero2 = 5;
            int division = numero1 / numero2;

            //Act
            int resultadoEsperado = 5;

            //Assert
            Assert.AreNotEqual(division, resultadoEsperado);
        }
    }
}