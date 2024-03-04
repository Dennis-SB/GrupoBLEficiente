using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class NationalIdTypeController : Controller
    {
        NationalIdTypeHelper entityHelper;

        #region Index
        // GET: Controller
        public ActionResult Index()
        {
            entityHelper = new NationalIdTypeHelper();
            List<NationalIdTypeViewModel> list = entityHelper.GetAll();
            return View(list);
        }
        #endregion

        #region Details
        // GET: Controller/Details/5
        public ActionResult Details(int id)
        {
            entityHelper = new NationalIdTypeHelper();
            NationalIdTypeViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }
        #endregion

        #region Create
        // GET: Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NationalIdTypeViewModel entity)
        {
            try
            {
                entityHelper = new NationalIdTypeHelper();
                entity = entityHelper.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Edit
        // GET: Controller/Edit/5
        public ActionResult Edit(int id)
        {
            entityHelper = new NationalIdTypeHelper();
            NationalIdTypeViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }

        // POST: Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NationalIdTypeViewModel entity)
        {
            try
            {
                entityHelper = new NationalIdTypeHelper();
                entity = entityHelper.Edit(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Delete
        // GET: Controller/Delete/5
        public ActionResult Delete(int id)
        {
            entityHelper = new NationalIdTypeHelper();
            NationalIdTypeViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }

        // POST: Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(NationalIdTypeViewModel entity)
        {
            try
            {
                entityHelper = new NationalIdTypeHelper();
                entityHelper.Delete(entity.IdType);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}