using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace school_record.Models
{
    public class stumodel
    {
          [Key]
        public String Id { get; set; }

        
        public int Rollno { get; set; }

        [Required(ErrorMessage = "Name Require")]
        public string Name { get; set; }

        public long MobileNo { get; set; }

       public stumodel()
        {
            this.Id = Guid.NewGuid().ToString();
                
        }

      
    }
}