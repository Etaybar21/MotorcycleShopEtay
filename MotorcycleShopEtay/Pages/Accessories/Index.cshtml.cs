using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Accessories
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<Accessorie> Accessorie { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Accessorie> AccessoriesIQ = from e in _context.Accessories select e;
            if (!String.IsNullOrEmpty(SearchString))
            {
                AccessoriesIQ = AccessoriesIQ.Where(e => e.Name.ToString().Contains(SearchString));

            }

            Accessorie = await AccessoriesIQ.ToListAsync();
            //Accessorie = await _context.Accessories.ToListAsync();
        }
    }
}
