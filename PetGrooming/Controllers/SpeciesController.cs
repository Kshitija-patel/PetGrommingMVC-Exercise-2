using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetGrooming.Data;
using PetGrooming.Models;
using System.Diagnostics;

namespace PetGrooming.Controllers
{
    public class SpeciesController : Controller
    {
        private PetGroomingContext db = new PetGroomingContext();
        // GET: Species
        public ActionResult Index()
        {
            return View();
        }
        //reference:class-files
        // List

        public ActionResult List()
        {
            List<Species> myspecies=db.Species.SqlQuery("Select * from species").ToList();
            return View(myspecies);
        }
        // Show

        public ActionResult Show(int id)
        {
            string query = "select * from species where speciesid=@id";
            SqlParameter sqlparams = new SqlParameter("@id", id);
    
            Species selectedspecies=db.Species.SqlQuery(query, sqlparams).FirstOrDefault();
            return View(selectedspecies);

        }


        public ActionResult Add()
        {
            return View();
        }
        // Add
        [HttpPost]

        public ActionResult Add(string Name)
        {
            string query = "insert into species (Name) values (@Name)";
            SqlParameter sqlparams = new SqlParameter("@Name", Name); 
            //sqlparams[0] = new SqlParameter("@Name", Name);
            db.Database.ExecuteSqlCommand(query, sqlparams);
            return RedirectToAction("List");
            
        }
        // Update
        public ActionResult Update(int id)
        {
            string query = "select * from species where speciesid=@id";
            SqlParameter sqlparams = new SqlParameter("@id", id);

            Species selectedspecies = db.Species.SqlQuery(query, sqlparams).FirstOrDefault();

            return View(selectedspecies);

        }
        // [HttpPost] Update
        [HttpPost]
        public ActionResult Update(int id, string SpeciesName)
        {
            string query = "Update species set Name=@SpeciesName where speciesid=@id";
            SqlParameter[] sqlparams = new SqlParameter[2];
            sqlparams[0] = new SqlParameter("@id", id);
            sqlparams[1] = new SqlParameter("@SpeciesName",SpeciesName);
            db.Database.ExecuteSqlCommand(query, sqlparams);
            return RedirectToAction("List");
        }
        
        // (optional) delete
        // [HttpPost] Delete
       public ActionResult ConfirmDelete(int id)
        {
            string query = "delete from species where speciesid=@id";
            SqlParameter sqlparams = new SqlParameter("@id", id);
            db.Database.ExecuteSqlCommand(query, sqlparams);
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            string query = "select * from species where speciesid=@id";
            SqlParameter sqlparams = new SqlParameter("@id", id);

            Species selectedspecies = db.Species.SqlQuery(query, sqlparams).FirstOrDefault();

            return View(selectedspecies);
        }
    }
}