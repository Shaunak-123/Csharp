using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HardwareSupplier.Models;

namespace HardwareSupplier.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddCustomer(SupplierModel smodel )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SupplierDBHandle sdb = new SupplierDBHandle();
                    if (sdb.AddSupplier(smodel))
                    {
                        ViewBag.Message = "Supplier Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            
            }
        }
            public ActionResult DisplayCustomer()
        {
            SupplierDBHandle handle = new SupplierDBHandle();
            ModelState.Clear();
            return View(handle.DisplayDetail());
        }
        }




    }

