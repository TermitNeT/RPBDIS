using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CourseWork.Data;
using CourseWork.Models;
using CourseWork.ViewModels;
using CourseWork.pages;
//using CourseWork.ViewModels.Filter;

namespace CourseWork.Controllers
{
    /// <summary>
    /// Контроллер для таблицы Работников.
    /// </summary>
    public class WorkersController : Controller
    {
        private readonly Construction_Context _context;

        public WorkersController(Construction_Context context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string Surname, string Name, string Position, int page = 1)
        {
            IEnumerable<Worker> workers = await _context.Workers.Include(j => j.Team).Include(f => f.Position).ToListAsync();

            // фильтрация
            workers = workers.Where(c => c.Surname.Contains(Surname ?? "") & c.Name.Contains(Name ?? "") & c.Position.PositionName.Contains(Position ?? ""));
            // Разбиение на страницы
            int pageSize = 10;
            int count = workers.Count();

            IEnumerable<Worker> items = workers.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                FilterViewModel = new FilterViewModel(Position, Surname, Name),
                workers = items
            };

            return View(viewModel);
        }

        // GET: Workers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _context.Workers
                .Include(w => w.Team)
                .FirstOrDefaultAsync(m => m.WorkerId == id);
            if (worker == null)
            {
                return NotFound();
            }

            return View(worker);
        }

        // GET: Workers/Create
        public IActionResult Create()
        {
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionName");
            return View();
        }

        // POST: Workers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkerId,Surname,Name,MiddleName,Age,Sex,Adress,Phone,Passport,PositionId,TeamId")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(worker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", worker.TeamId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionName", worker.PositionId);
            return View(worker);
        }

        // GET: Workers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _context.Workers.FindAsync(id);
            if (worker == null)
            {
                return NotFound();
            }
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", worker.TeamId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionName", worker.PositionId);
            return View(worker);
        }

        //Добавлены атрибуты в Bind
        // POST: Workers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkerId,Surname,Name,MiddleName,Age,Sex,Adress,Phone,Passport,PositionId,TeamId")] Worker worker)
        {
            if (id != worker.WorkerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(worker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(worker.WorkerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", worker.TeamId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionName", worker.PositionId);
            return View(worker);
        }

        // GET: Workers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var worker = await _context.Workers
                .Include(w => w.Team)
                .Include(w => w.Position)
                .FirstOrDefaultAsync(m => m.WorkerId == id);
            if (worker == null)
            {
                return NotFound();
            }

            return View(worker);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var worker = await _context.Workers.FindAsync(id);
            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkerExists(int id)
        {
            return _context.Workers.Any(e => e.WorkerId == id);
        }
    }
}
