using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mmaCrudPin.Models;

namespace mmaCrudPin.Controllers
{
    public class FightersController : Controller
    {
        private readonly mmaDbContext _context;

        public FightersController(mmaDbContext context)
        {
            _context = context;
        }

        // GET: Index da početna bude prazna
        public async Task<IActionResult> Index(string name)
        {
            var rez = await _context.mmaFighters.Where(c => c.deleted == null && c.figtherName.StartsWith(name)).ToListAsync();
            if (!ModelState.IsValid)
            {
                return View("Search", rez);
            }
            return View("Index", rez);
            //return View(await _context.mmaFighters.ToListAsync()); vraća listu svih boraca
        }

        
        public IActionResult Details(int? id, string name)
        {

            //linq method syntax
            // _context.mmaFighters.Where(m => m.fighterId == id).FirstOrDefault();

            //linq query syntax
            var mmaFighter = (from m in _context.mmaFighters where m.fighterId == id select m).FirstOrDefault();
            return View(mmaFighter);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("figtherName,age,mma_record,category,created,worth_salary")] mmaFighter m)
        {
            
            if (ModelState.IsValid)
            {
                m.created = DateTime.Now;
                _context.Add(m);
                await _context.SaveChangesAsync();
                ViewBag.Message = "Borac je kreiran";
                return View("Index", new mmaFighter[] { m });
               
            }
            return View(m);
            
        }

        
        
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find(id);
            //lamda linq method syntax 
            var mmaFighter = _context.mmaFighters.Where(i => i.fighterId == id).FirstOrDefault();
            if (mmaFighter == null)
            {
                return NotFound();
            }
            return View(mmaFighter);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("fighterId,figtherName,age,mma_record,category,created,modified,worth_salary")] mmaFighter m)
        {
            if (id != m.fighterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    m.modified = DateTime.Now;
                    _context.mmaFighters.Update(m);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = "Uspješno promijenjeno!";
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!mmaFighterExists(m.fighterId))
                    {
                        return NotFound();
                        
                    }
                    else
                    {
                        throw;
                    }
                }
                return View("Index", new mmaFighter[] { m });
            }
            return View(m);
            
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mma = await _context.mmaFighters.FirstOrDefaultAsync(m => m.fighterId == id);
            if (mma == null)
            {
                return NotFound();
            }
            return View(mma);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? Id, mmaFighter mf)
        {
            //briše iz baze
            var mmaf = await _context.mmaFighters.FindAsync(Id);
            mf.deleted = DateTime.Now;
            _context.mmaFighters.Remove(mmaf);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        private bool mmaFighterExists(int id)
        {
            return _context.mmaFighters.Any(e => e.fighterId == id);
        }

        //Search
        public IActionResult Search(string name, mmaFighter mm, string mma_name, bool exist=true)
        {
            //Linq method syntax
            var rez = _context.mmaFighters.Where(m => m.deleted == null && m.figtherName.StartsWith(name)).ToList();
            mmaFighter mma = _context.mmaFighters.Where(k => k.figtherName == mm.figtherName && k.fighterId == mm.fighterId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if(mma == null)
                {
                    ViewBag.fighterName = mma_name;
                }
                if (exist)
                {
                    ViewBag.Message = "Traženi borac je pronađen.";
                }
                if(!exist || rez.Count == 0)
                {
                    ViewBag.Message = "<b>Traženog borca nismo pronašli.</b>";
                }

                ViewBag.fighterName = name;
                return View("Index", rez);
                
            }
            else
            {
                if (rez.Count == 0)
                    ViewBag.Message = "<b>Traženog borca nismo pronašli.</b>";
            }
            return View("Index", rez);
        }
    }
}
