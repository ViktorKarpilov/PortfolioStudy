using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace PortfolioAplication.Models
{
    public class Work
    {

        [Key]
        public int Id { get; set; }

        public int Number { get; set; }
        //[Required]
        [DataType(DataType.Url)]
        public string Url { get; set; }
        //[Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public PhotoCollection Galery;
    }
    

}
