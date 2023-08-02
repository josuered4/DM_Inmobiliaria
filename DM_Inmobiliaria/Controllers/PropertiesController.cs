using DM_Inmobiliaria.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DM_Inmobiliaria.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly ApplicationDBContext DBContext;
        public PropertiesController(ApplicationDBContext dbContext) { DBContext = dbContext; }

        public IActionResult Index()
        {
            PropertiesEntity propertiesEntity = new PropertiesEntity();
            ViewData["ListProperties"] = DBContext.Properties.ToListAsync();
            return View(propertiesEntity);
        }

        public IActionResult Details(int IdProperty)
        {
            var propertiesEntity = DBContext.Properties.FirstOrDefault(p => p.Id == IdProperty);
            return Json(propertiesEntity);
        }

        public async Task<IActionResult> Create(PropertiesEntity propertiesEntity)
        {
            if (!ModelState.IsValid)
                return View(propertiesEntity);

            DBContext.Properties.Add(propertiesEntity);
            await DBContext.SaveChangesAsync();
            return Json(200);
        }

        public async Task<IActionResult> Delete(int IdProperty)
        {
            var model = await DBContext.Properties.FirstOrDefaultAsync(p => p.Id == IdProperty);
            if (model == null)
                return Json("Entidad No Encontrada");

            DBContext.Properties.Remove(model);
            await DBContext.SaveChangesAsync();
            return Json(200);

        }
    }
}
