using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Purchases
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
        ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
        ViewData["ShoppingCartId"] = new SelectList(_context.ShoppingCarts, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Purchase Purchase { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.purchases.Add(Purchase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
