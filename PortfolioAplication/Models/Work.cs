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
        
        //[DataType(DataType.Text)]
       // public string Photo { get; set; }

        public ICollection<Photo> Galery { get; set; }

        public Work(int Number)
        {
            this.Number = Number;
        }
        public Work(int Number,string Url) : this(Number)
        {
            this.Url = Url;
        }
        public Work(int Number,string Url,string Description) : this(Number, Url)
        {
            this.Description = Description;
        }
        /*public Work(int Number, string Url, string Description,string PhotoCollection) : this(Number, Url,Description)
        {
            this.Photo = PhotoCollection;
        }*/
    }
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }

        public int? WorkId;
        public Work Work { get; set; }
    }

}
