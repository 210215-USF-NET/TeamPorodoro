using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PomMvc.Models;
using PomBL;

namespace PomMvc.Controllers
{
    public class NoteController : Controller
    {
        private readonly IPomBL _pomBL;
        private readonly IMapper _mapper;
        public NoteController(IPomBL pomBL, IMapper mapper)
        {
            _pomBL = pomBL;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}