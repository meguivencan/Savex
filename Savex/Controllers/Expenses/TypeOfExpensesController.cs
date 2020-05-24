using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Savex.Data;
using Savex.Models.Expense;

namespace Savex.Controllers.Expenses
{
    public class TypeOfExpensesController : Controller
    {
        private readonly SavexContext _context;

        public TypeOfExpensesController(SavexContext context)
        {
            _context = context;
        }

        // GET: TypeOfExpenses
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeOfExpense.ToListAsync());
        }

        // GET: TypeOfExpenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfExpense = await _context.TypeOfExpense
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfExpense == null)
            {
                return NotFound();
            }

            return View(typeOfExpense);
        }

        // GET: TypeOfExpenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfExpenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExpenseTypeName,Comment")] TypeOfExpense typeOfExpense)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeOfExpense);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfExpense);
        }

        // GET: TypeOfExpenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfExpense = await _context.TypeOfExpense.FindAsync(id);
            if (typeOfExpense == null)
            {
                return NotFound();
            }
            return View(typeOfExpense);
        }

        // POST: TypeOfExpenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExpenseTypeName,Comment")] TypeOfExpense typeOfExpense)
        {
            if (id != typeOfExpense.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfExpense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfExpenseExists(typeOfExpense.Id))
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
            return View(typeOfExpense);
        }

        // GET: TypeOfExpenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfExpense = await _context.TypeOfExpense
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfExpense == null)
            {
                return NotFound();
            }

            return View(typeOfExpense);
        }

        // POST: TypeOfExpenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfExpense = await _context.TypeOfExpense.FindAsync(id);
            _context.TypeOfExpense.Remove(typeOfExpense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfExpenseExists(int id)
        {
            return _context.TypeOfExpense.Any(e => e.Id == id);
        }
    }
}
