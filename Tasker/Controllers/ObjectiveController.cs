using System.Web.Mvc;
using BusinessLogic;
using Domain;


namespace Tasker.Controllers
{
    public class ObjectiveController : Controller
    {
        ObjectiveManager _objectiveManager = new ObjectiveManager();

        public ActionResult Index()
        {
            return View(_objectiveManager.GetAll());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Objective());
        }

        [HttpPost]
        public ActionResult Add(Objective objective)
        {
            if (!ModelState.IsValid)
            {
                return View(objective);
            }

            _objectiveManager.Add(objective);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Objective editingObjective = _objectiveManager.Find(id);

            return View(editingObjective);
        }

        [HttpPost]
        public ActionResult Edit(Objective editedObjective)
        {
            _objectiveManager.Edit(editedObjective);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _objectiveManager.Delete(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _objectiveManager.Dispose();
            base.Dispose(disposing);
        }
    }
}