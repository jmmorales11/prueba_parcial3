//using NUnit.Framework;
//using ProyectoMVC.Dato;
//using ProyectoMVC.Models;
//using System;
//using TechTalk.SpecFlow;
//using TechTalk.SpecFlow.Assist;

//namespace SpecFlowTest.StepDefinitions
//{
//    [Binding]
//    public class IngresoProductoStepDefinitions
//    {
//        private readonly ProductSqlDataAccessLayer _productoDAL = new ProductSqlDataAccessLayer();

//        [Given(@"Llenar los campos de las BDD1")]
//        public void GivenLlenarLosCamposDeLasBDD(Table table)
//        {
//            var dataTable = table.Rows.Count();
//            dataTable.Should().BeGreaterThanOrEqualTo(1);
//        }

//        [When(@"El registro se ingresa en la base de datos1")]
//        public void WhenElRegistroSeIngresaEnLaBaseDeDatos(Table table)
//        {
//            var productos = table.CreateSet<Product>().ToList();
//            foreach (var item in productos)
//            {
//                _productoDAL.InsertProduct(item);
//            }
//        }

//        [Then(@"El producto con ID ""(.*)"" se encuentra en la base de datos con los siguientes detalles")]
//        public void ThenElProductoSeEncuentraEnLaBaseDeDatos(string expectedProductId, Table expectedTable)
//        {
//            var expectedProduct = expectedTable.Rows[0];
//            var product = new Product
//            {
//                ProductName = expectedProduct["ProductName"],
//                Category = expectedProduct["Category"],
//                Price = decimal.Parse(expectedProduct["Price"]),
//                StockQuantity = int.Parse(expectedProduct["StockQuantity"])
//            };

//            var producto = _productoDAL.GetProductByDetails(product);

//            Assert.IsNotNull(producto, "El producto no fue encontrado.");
//            Assert.AreEqual(expectedProduct["ProductName"], producto.ProductName);
//            Assert.AreEqual(expectedProduct["Category"], producto.Category);
//            Assert.AreEqual(decimal.Parse(expectedProduct["Price"]), producto.Price);
//            Assert.AreEqual(int.Parse(expectedProduct["StockQuantity"]), producto.StockQuantity);
//        }

//    }
//}
