using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        // Genre foreign key
        public Genre Genre { get; set; }
        public short GenreId { get; set; }
        ////////////////////
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
    }
}