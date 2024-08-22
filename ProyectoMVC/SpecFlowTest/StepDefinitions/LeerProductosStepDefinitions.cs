using NUnit.Framework;
using TechTalk.SpecFlow;
using ProyectoMVC.Dato;
using ProyectoMVC.Models;
using System.Linq;
using TechTalk.SpecFlow.Assist;

namespace ProyectoMVC.Tests.StepDefinitions
{
    [Binding]
    public class ProductStepDefinitions
    {
        private ProductSqlDataAccessLayer _productoDAL;
        private List<Product> _productosEnLaLista;

        public ProductStepDefinitions()
        {
            _productoDAL = new ProductSqlDataAccessLayer();
        }

        [Given(@"Existen los siguientes productos en la base de datos")]
        public void GivenExistenLosSiguientesProductosEnLaBaseDeDatos(Table table)
        {
            var productos = table.CreateSet<Product>().ToList();

            // Primero, limpia la base de datos para evitar conflictos con los datos existentes
            _productoDAL.DeleteAllProducts();  // Asegúrate de implementar este método si no existe

            foreach (var producto in productos)
            {
                // Inserta cada producto en la base de datos
                _productoDAL.InsertProduct(producto);
            }
        }

        [When(@"Solicito la lista de productos")]
        public void WhenSolicitoLaListaDeProductos()
        {
            _productosEnLaLista = _productoDAL.GetAllProducts().ToList();
        }

        [Then(@"Debería ver los siguientes productos en la lista")]
        public void ThenDeberiaVerLosSiguientesProductosEnLaLista(Table table)
        {
            var productosEsperados = table.CreateSet<Product>().ToList();

            foreach (var productoEsperado in productosEsperados)
            {
                var productoEnLaLista = _productosEnLaLista.FirstOrDefault(p =>
                    p.ProductName == productoEsperado.ProductName &&
                    p.Category == productoEsperado.Category &&
                    p.Price == productoEsperado.Price &&
                    p.StockQuantity == productoEsperado.StockQuantity);

                Assert.IsNotNull(productoEnLaLista, $"El producto {productoEsperado.ProductName} no se encontró en la lista.");
            }
        }
    }
}
