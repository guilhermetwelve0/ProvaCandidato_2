using ProvaCandidato.Data;
using ProvaCandidato.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Http.Filters;
using System.Web.Http.Description;
using System.Windows;

namespace ProvaCandidato.Controllers
{
    public class ClientesController : Controller
    {
        private ContextoPrincipal db = new ContextoPrincipal();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (db.Clientes.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(db.Clientes.Find(id));
        }

        // GET: Clientes/Create
        [EnableQuery]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,nome,data_nascimento,codigo_cidade")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
                string message = "Parabens";
                string title = "vc conseguiu criar um cliente";
                MessageBox.Show(message, title);
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (db.Clientes.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(db.Clientes.Find(id));
        }

        // POST: Clientes/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,nome,data_nascimento,codigo_cidade")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
                string message = "Parabens";
                string title = "vc conseguiu editar um cliente";
                MessageBox.Show(message, title);
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (db.Clientes.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(db.Clientes.Find(id));
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Clientes.Remove(db.Clientes.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
            string message = "Parabens";
            string title = "vc conseguiu deletar um cliente";
            MessageBox.Show(message, title);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class Generic : Cidade
    {

    }
    public class Generic2 : Cliente
    {

    }
}
