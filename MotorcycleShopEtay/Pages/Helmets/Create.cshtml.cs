﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Helmets
{
    public class CreateModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public CreateModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Helmet Helmet { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Helmets.Add(Helmet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
