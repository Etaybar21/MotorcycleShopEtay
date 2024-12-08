using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Motorcycles
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<Motorcycle> Motorcycle { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Motorcycle> MotorcyclesIQ = from e in _context.Motorcycles select e;
            if (!String.IsNullOrEmpty(SearchString))
            {
                MotorcyclesIQ = MotorcyclesIQ.Where(e => e.Name.ToString().Contains(SearchString));

            }

            Motorcycle = await MotorcyclesIQ.ToListAsync();
            //Motorcycle = await _context.Motorcycles.ToListAsync();
        }
    }
}
