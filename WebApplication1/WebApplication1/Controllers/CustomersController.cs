using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseWork.Data;
using CourseWork.Models;
using CourseWork.pages;
using CourseWork.ViewModels;

namespace CourseWork.Controllers
{
    /// <summary>
    /// Контроллер для таблицы Заказчиков
    /// </summary>
    public class CustomersController : Controller
    {
        private readonly Construction_Context _context;
        private int pageSize = 10;

        public CustomersController(Construction_Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Стартовая страница для Заказчиков
        /// </summary>
        /// <param name="Surname">Сортировка по фамилии</param>
        /// <param name="Name">Сортировка по имени</param>
        /// <param name="page">Номер страницы</param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string Surname, string Name, int page = 1)
        {
            IEnumerable<Customer> customers = await _context.Customers.ToListAsync(); // Получаем полный список заказчиков.
            
            // фильтрация
            customers = customers.Where(c => c.Surname.Contains(Surname ?? "") & c.Name.Contains(Name ?? "")); // Фильтруем полученный список по имени и фамилии.
            int count = customers.Count(); // Вычисляем кол-во записей.
            // Разбиение на страницы
            IEnumerable<Customer> items = customers.Skip((page - 1) * pageSize).Take(pageSize).ToList(); // Оставляем только те записи, которые подходят под заданную страницу.
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                FilterViewModel = new FilterViewModel(Surname, Name),
                customers = items
            };

            return View(viewModel);
        }


        /// <summary>
        /// Детальный вывод записи по заказчику
        /// </summary>
        /// <param name="id">Id заказчика</param>
        /// <returns>Представление с заданным заказчиком, либо NotFound</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Surname,Name,MiddleName,Adress,Phone,Passport")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Surname,Name,MiddleName,Adress,Phone,Passport")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
