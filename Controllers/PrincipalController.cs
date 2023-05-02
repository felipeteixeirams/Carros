using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carros.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: PrincipalController
        public ActionResult Index()
        {
            return View();
        }
        // GET: PrincipalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrincipalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrincipalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrincipalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrincipalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrincipalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrincipalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
