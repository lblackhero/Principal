using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equitool.Models
{
    public class RoleModel
    {
        public List<IdentityRole> roles { get; set; }

        public string respuesta;
    }

}
