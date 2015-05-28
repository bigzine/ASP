using System.ComponentModel.DataAnnotations;
using Nwd.BackOffice.Model;

namespace WebApplication.Models
{
    public class CreateViewModels
    {
   
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Duration)]
        [Required]
        public System.TimeSpan Duration { get; set; }

       [DataType(DataType.DateTime)]
        [Required]
        public System.DateTime ReleaseDate { get; set; }

        [Required]
        public string Type { get; set; }
        [Required]
        public string CoverImagePath { get; set; }
        [Required]
        public virtual Artist Artist { get; set; }
     
    }
}