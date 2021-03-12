using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PomBL;
using PomMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PomMvc.Controllers
{
    public class PomoController : Controller
    {
        private readonly IPomBL _pomBL;
        private readonly IMapper _mapper;
        public PomoController(IPomBL pomBL, IMapper mapper)
        {
            _pomBL = pomBL;
            _mapper = mapper;
        }
        // GET: PomoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PomoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PomoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PomoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PomoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PomoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PomoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PomoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
