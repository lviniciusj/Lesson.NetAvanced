using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using BibliotecaMVC.Utils;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace BibliotecaMVC.Controllers
{
    public class AutoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _hostingEnvironment;

        public AutoresController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _hostingEnvironment = environment;
        }

        // GET: Autor
        public async Task<IActionResult> Index(string filtroPesquisa, string ordenacao)
        {
            ViewBag.TituloSortParm = String.IsNullOrEmpty(ordenacao) ? "titulo_desc" : "";

            ViewBag.filtroPesquisa = filtroPesquisa;

            var autores = from a in _context.Autor
                         select a;

            if (!String.IsNullOrEmpty(filtroPesquisa))
            {
                autores = autores.Where(s => s.Nome.ToUpper().Contains(filtroPesquisa.ToUpper()));
            }

            switch (ordenacao)
            {
                case "titulo_desc":
                    autores = autores.OrderByDescending(s => s.Nome);
                    break;
                default:
                    autores = autores.OrderBy(s => s.Nome);
                    break;
            }

            return View(await autores.ToListAsync());
        }

        // GET: Autor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor.AsNoTracking()
                                .Include(a => a.LivroAutor)
                                .ThenInclude(li => li.Autor)
                                .SingleOrDefaultAsync(m => m.AutorID == id);
            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // GET: Autor/Create
        public IActionResult Create()
        {
            return View(new Autor());
        }

        // POST: Autor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutorID,Nome")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autor);
                await _context.SaveChangesAsync();
                _context.Update(autor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(autor);
        }
        

        // GET: Autor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var autor = await _context.Autor.Include(a => a.LivroAutor).SingleOrDefaultAsync(m => m.AutorID == id);            
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }
        // POST: Autor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
 // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("AutorID,Nome")] Autor autor)
        {
            if (id != autor.AutorID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var livroAutores = _context.LivroAutor.AsNoTracking().Where(la => la.AutorID == autor.AutorID);
                    _context.LivroAutor.RemoveRange(livroAutores);
                    await _context.SaveChangesAsync();                
                    
                    _context.Update(autor);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorExists(autor.AutorID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(autor);
        }

        // GET: Autor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var autor = await _context.Autor.SingleOrDefaultAsync(m => m.AutorID == id);
            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autor = await _context.Autor.SingleOrDefaultAsync(m => m.AutorID == id);
            _context.Autor.Remove(autor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AutorExists(int id)
        {
            return _context.Autor.Any(e => e.AutorID == id);
        }
    }
}
