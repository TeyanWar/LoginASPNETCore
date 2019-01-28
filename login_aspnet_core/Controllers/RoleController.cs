using LoginASPNETCore.Models;
using LoginData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LoginASPNETCore.Views.Role;

namespace LoginASPNETCore.Controllers
{
    public class RoleController : Controller
    {
        private IRole _interface;

        public RoleController(IRole roles)
        {
            _interface = roles;
        }

        public IActionResult Index()
        {
            var data = _interface.GetAll();

            var models = data.Select(d => new RoleModel
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description
            }).ToList();

            var pageModel = new IndexModel()
            {
                Roles = models
            };
            //IEnumerable<Role> rows = objects;

            return View(pageModel);
        }
    }
}
