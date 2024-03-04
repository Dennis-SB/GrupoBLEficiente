using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class JobTitleController : Controller
    {
        JobTitleHelper entityHelper;

        #region Index
        // GET: Controller
        public ActionResult Index()
        {
            entityHelper = new JobTitleHelper();
            List<JobTitleViewModel> list = entityHelper.GetAll();
            return View(list);
        }
        #endregion

        #region Details
        // GET: Controller/Details/5
        public ActionResult Details(int id)
        {
            entityHelper = new JobTitleHelper();
            JobTitleViewModel entity = entityHelper.GetByID(id);
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
        public ActionResult Create(JobTitleViewModel entity)
        {
            try
            {
                entityHelper = new JobTitleHelper();
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
            entityHelper = new JobTitleHelper();
            JobTitleViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }

        // POST: Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JobTitleViewModel entity)
        {
            try
            {
                entityHelper = new JobTitleHelper();
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
            entityHelper = new JobTitleHelper();
            JobTitleViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }

        // POST: Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(JobTitleViewModel entity)
        {
            try
            {
                entityHelper = new JobTitleHelper();
                entityHelper.Delete(entity.IdJobTitle);
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