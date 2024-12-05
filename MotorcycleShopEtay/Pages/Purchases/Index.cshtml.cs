using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Purchases
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<Purchase> Purchase { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Purchase> PurchasesIQ = from s in _context.purchases select s;
            if(!String.IsNullOrEmpty(SearchString))
                {
                    PurchasesIQ=PurchasesIQ.Where(s => s.ShoppingCartId.ToString().Contains(SearchString));

                }

            Purchase = (IList<Purchase>)PurchasesIQ.Include(p => p.Product)
                .Include(p => p.ShoppingCart).ToList(); 
            //Purchase = await _context.purchases
                //.Include(p => p.Product)
               // .Include(p => p.ShoppingCart).ToListAsync();
        }
    }
}
