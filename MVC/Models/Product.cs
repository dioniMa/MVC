using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Web.Mvc;

namespace MVC.Models
{
    public class Product
    {
        [Key]
        public int p_Id { get; set; }
        
        public string p_emri { get; set; }
        public string pershkrimi { get; set; }

        
        [Display(Name = "Category")]
        public int c_ID { get; set; }
        
      
        //[ForeignKey("c_ID")]
        public List<SelectListItem> Categories{ get; set; }

        
        
    
       
    }
}
