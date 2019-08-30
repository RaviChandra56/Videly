using System;

namespace Videly.Models
{
    /// <summary>
    /// Plane old CLR object(POCO) which represents state and behaviour of our application in terms of it's problem domain.
    /// In this case it does't have behaviour or logic it just have couple of properties, which we use for representing state.
    /// </summary>
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }//Navigation 
        public int GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}