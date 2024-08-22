using NUnit.Framework;
using ProyectoMVC.Dato;
using ProyectoMVC.Models;
using TechTalk.SpecFlow.Assist;

[Binding]
public class ActualizarProductoStepDefinitions
{
    private readonly ProductSqlDataAccessLayer _productoDAL = new ProductSqlDataAccessLayer();
    private Product _productoOriginal;

    [Given(@"El producto con los siguientes detalles está en la base de datos")]
    public void GivenElProductoConLosSiguientesDetallesEstaEnLaBaseDeDatos(Table table)
    {
        // Asume que el producto ya está en la base de datos.
        _productoOriginal = table.CreateInstance<Product>();

        // Verifica que el producto ya existe en la base de datos
        var producto = _productoDAL.GetProductByDetails(new Product
        {
            ProductName = _productoOriginal.ProductName,
            Category = _productoOriginal.Category,
            Price = _productoOriginal.Price,
            StockQuantity = _productoOriginal.StockQuantity
        });

        if (producto == null)
        {
            throw new InvalidOperationException("El producto no existe en la base de datos y no se puede actualizar.");
        }

        // Almacena el ID del producto para actualizarlo más tarde
        _productoOriginal.ProductId = producto.ProductId;
    }

    [When(@"Actualizo el producto con los siguientes detalles")]
    public void WhenActualizoElProductoConLosSiguientesDetalles(Table table)
    {
        var updatedProduct = table.CreateInstance<Product>();
        updatedProduct.ProductId = _productoOriginal.ProductId; // Asegúrate de mantener el ProductId para la actualización.

        _productoDAL.UpdateProduct(updatedProduct);
    }

    [Then(@"El producto debería tener los siguientes detalles actualizados")]
    public void ThenElProductoDeberiaTenerLosSiguientesDetallesActualizados(Table table)
    {
        var expectedProduct = table.Rows[0];
        var product = new Product
        {
            ProductName = expectedProduct["ProductName"],
            Category = expectedProduct["Category"],
            Price = decimal.Parse(expectedProduct["Price"]),
            StockQuantity = int.Parse(expectedProduct["StockQuantity"])
        };

        var producto = _productoDAL.GetProductByDetails(product);

        Assert.IsNotNull(producto, "El producto no fue encontrado.");
        Assert.AreEqual(expectedProduct["ProductName"], producto.ProductName);
        Assert.AreEqual(expectedProduct["Category"], producto.Category);
        Assert.AreEqual(decimal.Parse(expectedProduct["Price"]), producto.Price);
        Assert.AreEqual(int.Parse(expectedProduct["StockQuantity"]), producto.StockQuantity);
    }
}
