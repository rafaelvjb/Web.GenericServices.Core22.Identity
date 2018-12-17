using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericServices;
using GenericServices.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMultiContext.DTOs;

namespace WebMultiContext.Controllers
{
    public class PessoassController : Controller
    {
        private readonly ICrudServices _service;
        public IStatusGeneric Status => _service;

        public PessoassController(ICrudServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var lista = _service.ReadManyNoTracked<PessoaDto>();
            return View(lista);
        }

        // GET: Pessoass/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = _service.ReadSingle<PessoaDto>();
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoass/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoass/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaDto pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View(pessoa);
            }

            _service.CreateAndSave(pessoa);
            if (_service.IsValid)
                return RedirectToAction("Index", new { message = /* _service.Message */ "Criado com sucesso" });

            //Error state
            _service.CopyErrorsToModelState(ModelState, pessoa, nameof(pessoa));
            return View(pessoa);
        }

        // GET: Pessoass/Edit/5
        public ActionResult Edit(Guid id)
        {

            var pessoa = _service.ReadSingle<PessoaDto>(id);


            return View(pessoa);
        }

        // POST: Pessoass/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, PessoaDto pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View(pessoa);
            }

            _service.UpdateAndSave(pessoa);
            if (_service.IsValid)
                return RedirectToAction("Index", new { message = /* _service.Message */ "Alterado com sucesso" });

            //Error state
            _service.CopyErrorsToModelState(ModelState, pessoa, nameof(pessoa));
            return View(pessoa);
        }

        // GET: Pessoass/Delete/5
        public ActionResult Delete(Guid id)
        {
            var pessoa = _service.ReadSingle<PessoaDto>(id);


            return View(pessoa);
        }

        // POST: Pessoass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var pessoa = _service.ReadSingle<PessoaDto>(id);
            pessoa.Deletado = true;

            _service.UpdateAndSave(pessoa);
            if (_service.IsValid)
                return RedirectToAction("Index", new { message = /* _service.Message */ "Deletado com sucesso" });

            //Error state
            _service.CopyErrorsToModelState(ModelState, pessoa, nameof(pessoa));
            return View(pessoa);
        }
    }
}