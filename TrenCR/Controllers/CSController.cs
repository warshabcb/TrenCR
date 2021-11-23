﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrenCR.Data;
using Microsoft.EntityFrameworkCore;

namespace TrenCR.Controllers
{
    public class CSController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CSController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.CS.ToListAsync());
        }

        public String Fecha()
        {
            return DateTime.Today.ToString("dd/MM/yyyy");
        }
        public String Hora()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
