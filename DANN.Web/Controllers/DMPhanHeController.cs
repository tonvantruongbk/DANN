﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DANN.Web.Controllers
{
    public class DMPhanHeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        DANN.Model.DANNContext db = new DANN.Model.DANNContext();

        [ValidateInput(false)]
        public ActionResult PhanHeGrid()
        {
            var model = db.DM_PhanHe;
            return PartialView("_PhanHeGrid", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult PhanHeGridAddNew(DANN.Model.DM_PhanHe item)
        {
            var model = db.DM_PhanHe;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_PhanHeGrid", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult PhanHeGridUpdate(DANN.Model.DM_PhanHe item)
        {
            var model = db.DM_PhanHe;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.PhanHe_Id == item.PhanHe_Id);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_PhanHeGrid", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult PhanHeGridDelete(System.Int32 PhanHe_Id)
        {
            var model = db.DM_PhanHe;
            if (PhanHe_Id >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.PhanHe_Id == PhanHe_Id);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_PhanHeGrid", model.ToList());
        }
    }
}