using System;
using System.Threading.Tasks;
using FrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly Context _context;
        public ProductViewComponent(Context context)
        {
            _context = context;
        }

        public async Task < IViewComponentResult> InvokeAsync()
        {
            List<Product> products = _context.Products
                .Include(0=> p.Category)
                .Take(8)
                .ToList()

                return View(await Task.FromResult(products));
        }

    }
}
