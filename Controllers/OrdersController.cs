﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductDilvery_MVC.Data;
using ProductDilvery_MVC.Models;

namespace ProductDilvery_MVC.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly PD_MVCDbContext _context;

        public OrdersController(PD_MVCDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var pD_MVCDbContext = _context.Order.Include(o => o.Client).Include(o => o.Company).Include(o => o.Product);
            return View(await pD_MVCDbContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Client)
                .Include(o => o.Company)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["Clientid"] = new SelectList(_context.Client, "Id", "Name");
            ViewData["Companyid"] = new SelectList(_context.Comapny, "Id", "Name");
            ViewData["Productid"] = new SelectList(_context.Product, "Id", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Clientid,Companyid,Productid,order,Expected")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Clientid"] = new SelectList(_context.Client, "Id", "Name", order.Clientid);
            ViewData["Companyid"] = new SelectList(_context.Comapny, "Id", "Name", order.Companyid);
            ViewData["Productid"] = new SelectList(_context.Product, "Id", "Name", order.Productid);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["Clientid"] = new SelectList(_context.Client, "Id", "Name", order.Clientid);
            ViewData["Companyid"] = new SelectList(_context.Comapny, "Id", "Name", order.Companyid);
            ViewData["Productid"] = new SelectList(_context.Product, "Id", "Name", order.Productid);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Clientid,Companyid,Productid,order,Expected")] Order order)
        {
            if (id != order.Id)
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
                    if (!OrderExists(order.Id))
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
            ViewData["Clientid"] = new SelectList(_context.Client, "Id", "Name", order.Clientid);
            ViewData["Companyid"] = new SelectList(_context.Comapny, "Id", "Name", order.Companyid);
            ViewData["Productid"] = new SelectList(_context.Product, "Id", "Name", order.Productid);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Client)
                .Include(o => o.Company)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
