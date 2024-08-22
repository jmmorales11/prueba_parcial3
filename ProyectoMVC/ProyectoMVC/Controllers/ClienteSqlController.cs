using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Dato;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class ClienteSqlController : Controller
    {
        ClienteSqlDataAccessLayer objClienteDAL = new ClienteSqlDataAccessLayer();
        // GET: ClienteSqlController
        public ActionResult Index()
        {
            List<ClienteSql> listClient = new List<ClienteSql>();
            listClient = objClienteDAL.GetAllClientes().ToList();
            return View(listClient);
        }

        // GET: ClienteSqlController/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: ClienteSqlController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteSqlController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteSql cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objClienteDAL.InsertCliente(cliente);
                    return RedirectToAction(nameof(Index));
                }
                return View(cliente);
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteSqlController/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteSql cliente = objClienteDAL.GetAllClientes().FirstOrDefault(c => c.Codigo == id);
            return View(cliente);
        }

        // POST: ClienteSqlController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteSql cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objClienteDAL.UpdateCliente(cliente);
                    return RedirectToAction(nameof(Index));
                }
                return View(cliente);
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: ClienteSqlController/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteSql cliente = objClienteDAL.GetAllClientes().FirstOrDefault(c => c.Codigo == id);
            return View(cliente);
        }

        // POST: ClienteSqlController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                objClienteDAL.DeleteCliente(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
