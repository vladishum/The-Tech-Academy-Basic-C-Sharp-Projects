using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var insurees = (from c in db.Insurees
                                    select c).ToList();
                    var InsureesV = new List<Insuree>();
                    foreach (var insuree in insurees)
                    {
                        var insureeV = new Insuree();
                        insureeV.Id = insuree.Id;
                        insureeV.FirstName = insuree.FirstName;
                        insureeV.LastName = insuree.LastName;
                        insureeV.EmailAddress = insuree.EmailAddress;
                        InsureesV.Add(insureeV);
                    }

                    return View(InsureesV);
                }
            }
        }
    }
}