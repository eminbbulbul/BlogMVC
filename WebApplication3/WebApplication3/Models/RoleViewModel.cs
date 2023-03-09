//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System;
//using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class RoleViewModel
    {

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string name { get; set; }
    }
}
