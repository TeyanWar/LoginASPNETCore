using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoginASPNETCore.Models;


namespace LoginASPNETCore.Views.Role
{
    public class IndexModel
    {
        public IEnumerable<RoleModel> Roles { get; set; }
    }
}