using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Dato;
using ProyectoMVC.Models;
using System.Collections.Generic;

namespace ProyectoMVC.Controllers
{
    public class ProductController : Controller
    {
        ProductSqlDataAccessLayer objProductDAL = new ProductSqlDataAccessLayer();

        // GET: Product
        public ActionResult Index()
        {
            List<Product> listProducts = objProductDAL.GetAllProducts().ToList();
            return View(listProducts);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product product = objProductDAL.GetAllProducts().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objProductDAL.InsertProduct(product);
                    return RedirectToAction(nameof(Index));
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = objProductDAL.GetAllProducts().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objProductDAL.UpdateProduct(product);
                    return RedirectToAction(nameof(Index));
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = objProductDAL.GetAllProducts().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                objProductDAL.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
