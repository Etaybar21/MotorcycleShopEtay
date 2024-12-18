﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Customer> CustomersIQ = from k in _context.Customers select k;
            if (!String.IsNullOrEmpty(SearchString))
            {
                CustomersIQ = CustomersIQ.Where(k => k.CustomerID.ToString().Contains(SearchString));

            }

            Customer = await CustomersIQ.ToListAsync();
            //Customer = await _context.Customers.ToListAsync();
        }
    }
}
