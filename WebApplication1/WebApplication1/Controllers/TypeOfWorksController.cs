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
    /// Контроллер для таблицы Виды работ.
    /// </summary>
    public class TypeOfWorksController : Controller
    {
        private readonly Construction_Context _context;

        public TypeOfWorksController(Construction_Context context)
        {
            _context = context;
        }

        private ICollection<TypeOfWork> Filter(IEnumerable<TypeOfWork> types, int numMat)
        {
            ICollection<TypeOfWork> types1 = new List<TypeOfWork>();
            if (numMat < 0 && numMat > 6)
            {
                types1 = types.ToList();
            }
            else
            {
                ICollection<Material> materials = _context.Materials.ToList();
                foreach (TypeOfWork type in types)
                {
                    int num = 0;
                    foreach (Material item in materials)
                    {
                        int n = type.ListMaterials.Count(c => c.Material.Equals(item));
                        if (n == 1) num++;
                    }

                    if (num >= numMat)
                    {
                        types1.Add(type);
                    }
                }
            }
            return types1;
        }

        public async Task<IActionResult> Index(string NumOfMaterials = "0" , int page = 1) 
        {
            int pageSize = 10;
            int numOfMaterials;
            IEnumerable<TypeOfWork> types = _context.TypeOfWorks.Include(j => j.ListMaterials).ThenInclude(j => j.Material);
            
            // фильтрация
            int num1 = types.Count();
            try { numOfMaterials = Convert.ToInt32(NumOfMaterials); }
            catch { numOfMaterials = 0; }

            types = Filter(types, numOfMaterials).ToList();
            int num = types.Count();

            IQueryable<Material> material = _context.Materials.Include(j => j.ListMaterials);
            List<string> strlist = new List<string>();

            foreach (TypeOfWork i in types)
            {
                IQueryable<Material> products = _context.Materials.Include(p => p.ListMaterials)
                    .Where(p => p.ListMaterials.Any(c => c.TypeOfWork.TypeOfWorkId == i.TypeOfWorkId));
                StringBuilder s = new StringBuilder();                
                foreach (Material j in products)
                {
                    s.Append(j.MaterialName).Append(", ");
                }
                string str = s.ToString().TrimEnd(' ').TrimEnd(',');
                strlist.Add(str);
            }
            List<string> stritems = strlist.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int count = types.Count();
            IEnumerable<TypeOfWork> items = types.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                TypeOfWorks = items,
                FilterViewModel = new FilterViewModel(NumOfMaterials),
                List = stritems
            };

            return View(viewModel);
        }

        // GET: TypeOfWorks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfWork = await _context.TypeOfWorks
                .FirstOrDefaultAsync(m => m.TypeOfWorkId == id);
            if (typeOfWork == null)
            {
                return NotFound();
            }

            return View(typeOfWork);
        }

        // GET: TypeOfWorks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeOfWorkId,WorkName,Description,Price")] TypeOfWork typeOfWork)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeOfWork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfWork);
        }

        // GET: TypeOfWorks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfWork = await _context.TypeOfWorks.FindAsync(id);
            if (typeOfWork == null)
            {
                return NotFound();
            }
            return View(typeOfWork);
        }

        // POST: TypeOfWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeOfWorkId,WorkName,Description,Price")] TypeOfWork typeOfWork)
        {
            if (id != typeOfWork.TypeOfWorkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfWork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfWorkExists(typeOfWork.TypeOfWorkId))
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
            return View(typeOfWork);
        }

        // GET: TypeOfWorks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfWork = await _context.TypeOfWorks
                .FirstOrDefaultAsync(m => m.TypeOfWorkId == id);
            if (typeOfWork == null)
            {
                return NotFound();
            }

            return View(typeOfWork);
        }

        // POST: TypeOfWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfWork = await _context.TypeOfWorks.FindAsync(id);
            _context.TypeOfWorks.Remove(typeOfWork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfWorkExists(int id)
        {
            return _context.TypeOfWorks.Any(e => e.TypeOfWorkId == id);
        }
    }
}
