using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEfCoreWebApplication.Data;
using RazorEfCoreWebApplication.Models;

namespace RazorEfCoreWebApplication.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorEfCoreWebApplication.Data.EFCoreContext _context;

        public IndexModel(RazorEfCoreWebApplication.Data.EFCoreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
