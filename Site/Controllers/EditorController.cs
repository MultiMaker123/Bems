using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using Site.Abstract;
using Site.ViewModels;
using Site.Concrete;
using Site.DB;
using Site.Infrastructure;

namespace Site.Controllers
{
    public class EditorController : Controller
    {
        private IBemsRepository repo;

        public ViewResult Edit()
        {
            EditorViewModel viewModel = new EditorViewModel
            {
                Papers = repo.Reports,
                viewContext = "report"
            };
            return View(viewModel);
        }

        public ViewResult Delete(string viewContext, int Ids)
        {
            repo.DeleteReports(Ids);
            EditorViewModel viewModel = new EditorViewModel
            {
                Papers = repo.Reports,
                viewContext = viewContext
            };

            return View("Edit", viewModel);
        }

        [HttpPost]
        public ViewResult Update(string viewContext, Report report)
        {
            repo.SaveReport(report);
            EditorViewModel viewModel = new EditorViewModel
            {
                Papers = repo.Reports,
                viewContext = viewContext
            };

            return View("Edit", viewModel);
        }

        public ViewResult Create(string viewContext)
        {
            repo.CreateReport();
            EditorViewModel viewModel = new EditorViewModel
            {
                Papers = repo.Reports,
                viewContext = viewContext
            };

            return View("Edit", viewModel);
        }

        public EditorController(IBemsRepository bemsRepo)
        {
            this.repo = bemsRepo;
        }
    }
}
