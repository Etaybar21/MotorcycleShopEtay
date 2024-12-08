using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Deta;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Pages.Helmets
{
    public class IndexModel : PageModel
    {
        private readonly MotorcycleShopEtay.Deta.MotorcycleShopContext _context;

        public IndexModel(MotorcycleShopEtay.Deta.MotorcycleShopContext context)
        {
            _context = context;
        }

        public IList<Helmet> Helmet { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Helmet> HelmetsIQ = from d in _context.Helmets select d;
            if (!String.IsNullOrEmpty(SearchString))
            {
                HelmetsIQ = HelmetsIQ.Where(d => d.Name.ToString().Contains(SearchString));

            }

            Helmet = await HelmetsIQ.ToListAsync();
            //Helmet = await _context.Helmets.ToListAsync();
        }
    }
}
