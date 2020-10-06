using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaEx04.Context;
using ProvaWeb2Ex4.Models;

namespace ProvaEx04.Controllers
{
    public class ProfessorsController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Professors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Email,Telefone,Endereco,Disciplina")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                await db.SaveChangesAsync();

            }

            return View(professor);
        }


    }
}
