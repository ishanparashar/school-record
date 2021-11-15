using school_record.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace school_record.Controllers
{
    public class HomeController : Controller
    {
        // GET:
        // 3.1.1 
        StudentRepository context = new StudentRepository();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Detail()
        {
            List<stumodel> stu = context.Collection().ToList();
            return View(stu);
 
        }
        public ActionResult Create()
        {
            stumodel stu = new stumodel();
            return View(stu);

        }
        [HttpPost]
        public ActionResult Create(stumodel stu)
        {
            if (!ModelState.IsValid)
            {
                return View(stu);
            }
            else
            {
                context.Insert(stu);
                context.Commit();

                return RedirectToAction("Detail");
            }
        }
        
        public ActionResult details(string id)
        {             stumodel stu = context.Find(id);

            
            return View(stu);
        }

        public ActionResult Edit(string id)
        {
            stumodel stu = context.Find(id);

            return View(stu);

        }
        [HttpPost]

        public ActionResult Edit(string id , stumodel stu)
        {
            stumodel ed = context.Find(id);
            ed.Rollno = stu.Rollno;          
            ed.MobileNo = stu.MobileNo;
            ed.Name = stu.Name;
           
            context.Commit();
            return RedirectToAction("Detail");
        }
        public ActionResult Delete(string id)
        {
            stumodel stu = context.Find(id);
            return View(stu);
        }
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult ConformDelete(string id , stumodel stu)
        {
            stumodel del = context.Find(id);
                context.remove(del);
            context.Commit();
            return RedirectToAction("Detail");
        }
    }
}