using System;
using Caballero;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba_Save()
        {
            //organizar
            Company comp = new Company("Adriana",50.5);
            double ValorEsperado = 60.5;

            //actuar
            comp.Save(10);
            double ValorObtenido = comp.SaveProject;

            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);
        }

        [TestMethod]
        public void Prueba_Spend()
        {
            //organizar
            Company comp = new Company("Adriana", 50.5);
            double ValorEsperado = 40.5;

            //actuar
            comp.Spend(10);
            double ValorObtenido = comp.SaveProject;

            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);
            
        }


        [TestMethod]
        public void Prueba_Nombre()
        {
            //organizar
            Company comp = new Company("Adriana", 50.5);
            String ValorEsperado = "AdrianaCaballero";

            //actuar
            comp.ChangeName("AdrianaCaballero");
            String ValorObtenido = comp.Name;


            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);


        }
    }
}
