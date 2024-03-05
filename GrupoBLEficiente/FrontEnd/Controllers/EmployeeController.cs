using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeHelper entityHelper;
        private NationalIdTypeHelper nationalIdTypeHelper;
        private JobTitleHelper jobTitleHelper;

        public EmployeeController()
        {
            entityHelper = new EmployeeHelper();
            nationalIdTypeHelper = new NationalIdTypeHelper();
            jobTitleHelper = new JobTitleHelper();
        }

        #region Index
        // GET: Controller
        public ActionResult Index()
        {
            List<EmployeeViewModel> entities = entityHelper.GetAll();
            return View(entities);
        }
        #endregion

        #region Details
        // GET: Controller/Details/5
        public ActionResult Details(int id)
        {
            EmployeeViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }
        #endregion

        #region Create
        // GET: Controller/Create
        public ActionResult Create()
        {
            EmployeeViewModel entity = new EmployeeViewModel();
            entity.NationalIdTypes = nationalIdTypeHelper.GetAll();
            entity.JobTitles = jobTitleHelper.GetAll();
            return View(entity);
        }

        // POST: Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel entity)
        {
            try
            {
                entityHelper.Add(entity);
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
            EmployeeViewModel entity = entityHelper.GetByID(id);
            entity.NationalIdTypes = nationalIdTypeHelper.GetAll();
            entity.JobTitles = jobTitleHelper.GetAll();
            return View(entity);
        }

        // POST: Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel entity)
        {
            try
            {
                entityHelper.Edit(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        // GET: Controller/Delete/5
        public ActionResult Delete(int id)
        {
            EmployeeViewModel entity = entityHelper.GetByID(id);
            return View(entity);
        }

        #region Delete
        // POST: Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmployeeViewModel entity)
        {
            try
            {
                entityHelper.Delete(entity.IdEmployee);
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