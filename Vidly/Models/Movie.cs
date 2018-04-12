using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "A genre is required.")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "A release date is required.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }
    }
}