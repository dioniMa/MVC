using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models
{
    public class Category
    {
        [Key]
        public int c_ID { get; set; }
        

        public string c_emri { get; set; }

    }
}
