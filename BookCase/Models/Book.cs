using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(13)]
        [MinLength(10)]
        [Required]
        public int Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime PublishDate { get; set; }
    }
}
