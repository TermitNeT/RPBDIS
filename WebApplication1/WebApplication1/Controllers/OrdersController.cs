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

namespace CourseWork.Controllers
{
    /// <summary>
    /// Контроллер для таблицы Заказов.
    /// </summary>
    public class OrdersController : Controller
    {
        private readonly Construction_Context _context;

        public OrdersController(Construction_Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string Surname, string Name, int page = 1)
        {
            IQueryable<Order> orders = _context.Orders
                .Include(j => j.Team)
                .Include(j => j.TypeOfWork)
                .ThenInclude(j => j.ListMaterials)
                .ThenInclude(j => j.Material)
                .Include(j => j.Customer);

            int pageSize = 10;
            // фильтрация
            orders = orders.Where(j => j.Customer.Surname.Contains(Surname ?? "") & j.Customer.Name.Contains(Name ?? ""));

            int count = await orders.CountAsync();
            IEnumerable<Order> items = await orders.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                orders = items,
                FilterViewModel = new FilterViewModel(Surname, Name),
            };

            return View(viewModel);
        }
        

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }          

            var order = await _context.Orders
               .Include(j => j.Team)
               .Include(j => j.TypeOfWork)
               .ThenInclude(j => j.ListMaterials)
               .ThenInclude(j => j.Material)
               .Include(j => j.Customer).FirstOrDefaultAsync(m => m.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Surname");
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            ViewData["TypeOfWorkId"] = new SelectList(_context.TypeOfWorks, "TypeOfWorkId", "WorkName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,TeamId,CustomerId,TypeOfWorkId,Price,StartDate,FinishDate,ComplectionStatus,PayStatus")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", order.CustomerId);
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamId", order.Team.TeamId);
            ViewData["TypeOfWorkId"] = new SelectList(_context.TypeOfWorks, "TypeOfWorkId", "TypeOfWorkId", order.TypeOfWorkId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order order = await _context.Orders.SingleOrDefaultAsync(m => m.OrderId == id);

            //var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Surname", order.CustomerId);
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", order.TeamId);
            ViewData["TypeOfWorkId"] = new SelectList(_context.TypeOfWorks, "TypeOfWorkId", "WorkName", order.TypeOfWorkId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,TeamId,CustomerId,TypeOfWorkId,Price,StartDate,FinishDate,ComplectionStatus,PayStatus")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Surname", order.CustomerId);
            ViewData["TeamId"] = new SelectList(_context.Teams, "TeamId", "TeamId", order.TeamId);
            ViewData["TypeOfWorkId"] = new SelectList(_context.TypeOfWorks, "TypeOfWorkId", "TypeOfWorkId", order.TypeOfWorkId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Team)
                .Include(o => o.TypeOfWork)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
