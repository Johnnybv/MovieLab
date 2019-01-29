using System;
using System.Collections.Generic;
using System.Text;

namespace Movie
{
    public class Movie
    {
        public string Name { get; set; }
        public Rating Rating { get; set; }
        public Genre Genre { get; set; }

        public Movie(String name, Rating rating, Genre genre)
        {
            this.Name = name;
            this.Rating = rating;
            this.Genre = genre;
        }

        
        public override bool Equals(object o)
        {
            if (this == o) return true;
            if (!(o is Movie)) return false;
            Movie movie = (Movie)o;
            return Name == movie.Name && Rating == movie.Rating &&
                Genre == movie.Genre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Rating, Genre);
        }

        public override string ToString()
        {
            return "Movie{" +
                "name='" + Name + '\'' +
                ", rating=" + Rating +
                ", genre=" + Genre +
                '}';
        }
    }
}


