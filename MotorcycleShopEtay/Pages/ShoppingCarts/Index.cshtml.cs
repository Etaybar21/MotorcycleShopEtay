using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.ShoppingCarts
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<ShoppingCart> ShoppingCart { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<ShoppingCart> ShoppingCartsIQ = from s in _context.ShoppingCarts select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                ShoppingCartsIQ = ShoppingCartsIQ.Where(s => s.Id.ToString().Contains(SearchString));

            }

            //ShoppingCart = await ShoppingCartsIQ.ToListAsync();
            ShoppingCart = await ShoppingCartsIQ
                .Include(s => s.Customer).ToListAsync();
        }
    }
}
