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
    public class UserController : Controller
    {
        private readonly IPomBL _pomBL;
        private readonly IMapper _mapper;
        public UserController(IPomBL pomBL, IMapper mapper)
        {
            _pomBL = pomBL;
            _mapper = mapper;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View(_pomBL.GetUsers().Select(user => _mapper.cast2UserCRVM(user)).ToList());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserCRVM newUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _pomBL.CreateUser(_mapper.cast2User(newUser));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
