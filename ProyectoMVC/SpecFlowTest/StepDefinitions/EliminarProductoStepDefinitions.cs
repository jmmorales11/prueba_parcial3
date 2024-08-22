using NUnit.Framework;
using ProyectoMVC.Dato;
using ProyectoMVC.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class EliminarProductoStepDefinitions
    {
        private readonly ProductSqlDataAccessLayer _productoDAL = new ProductSqlDataAccessLayer();

        [Given(@"Buscar en la bdd")]
        public void GivenBuscarEnLaBdd(Table table)
        {
            var expectedProduct = table.CreateInstance<Product>();
            var producto = _productoDAL.GetProductByDetails(expectedProduct);
            Assert.IsNotNull(producto, "El producto no fue encontrado en la base de datos.");
        }

        [When(@"Eliminar de la bdd")]
        public void WhenEliminarDeLaBdd(Table table)
        {
            var productToDelete = table.CreateInstance<Product>();
            var producto = _productoDAL.GetProductByDetails(productToDelete);

            if (producto != null)
            {
                // Verificar si el stock es cero
                if (producto.StockQuantity == 0)
                {
                    _productoDAL.DeleteProduct(producto.ProductId);
                }
                else
                {
                    Assert.Fail("El producto no puede ser eliminado porque su stock no es cero.");
                }
            }
            else
            {
                Assert.Fail("El producto no fue encontrado en la base de datos para eliminar.");
            }
        }

        [Then(@"Que ya no exista en la bdd")]
        public void ThenQueYaNoExistaEnLaBdd(Table table)
        {
            var productToVerify = table.CreateInstance<Product>();
            var producto = _productoDAL.GetProductByDetails(productToVerify);

            Assert.IsNull(producto, "El producto aún existe en la base de datos.");
        }
    }
}
