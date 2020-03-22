 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CourseWork.Data;
using CourseWork.Models;
using CourseWork.pages;
using CourseWork.ViewModels;
using System.Text;

namespace CourseWork.Controllers
{
    /// <summary>
    /// Контроллер для таблицы Бригады.
    /// </summary>
    public class TeamsController : Controller
    {
        private readonly Construction_Context _context;

        public TeamsController(Construction_Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            IEnumerable<Team> teams = _context.Teams.Include(j => j.Workers)
                .Include(j => j.Orders)
                .ThenInclude(j => j.TypeOfWork);

            int pageSize = 10;
            teams = teams.Where(j => j.Orders.Any(f => f.TypeOfWork.WorkName.Length != 0));

            IEnumerable<TypeOfWork> types = await _context.TypeOfWorks.ToListAsync();

            List<string> strlist = new List<string>(); // Содержит список рабочих в бригаде (по специальностям)
            List<string> strNum = new List<string>(); // Содержит список количества выполненных заказов	

            foreach (Team i in teams)
            {
                strlist.Add(GetWorkers(i));
                int num = 0;
                foreach (Order item in i.Orders)
                {
                    if (item.ComplectionStatus is true)
                    {
                        num++;
                    }
                }
                strNum.Add(num.ToString());
            }

            List<string> stritems = strlist.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            IEnumerable<Team> items = teams.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int count = await _context.Teams.CountAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                teams = items,
                List = stritems,
                TypeOfWorks = types,
                ListNum = strNum
            };

            return View(viewModel);
        }

        private string GetWorkers(Team team)
        {
            IEnumerable<Worker> workers = _context.Workers.Include(p => p.Team).Include(f => f.Position).Where(p => p.TeamId == team.TeamId);

            StringBuilder s = new StringBuilder(" ");
            foreach (Worker j in workers) s.Append(j.Position.PositionName).Append(", ");

            return s.ToString();
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.TeamId == id);
            if (team == null)
            {
                return NotFound();
            }

            IndexViewModel viewModel = new IndexViewModel
            {
                team = team,
                teamInfo = GetWorkers(team),
            };

            return View(viewModel);
        }

        // GET: Teams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeamId,TeamName")] Team team)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(team);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch { }
            return View(team);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeamId,TeamName")] Team team)
        {
            if (id != team.TeamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.TeamId))
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
            return View(team);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.TeamId == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.TeamId == id);
        }
    }
}
