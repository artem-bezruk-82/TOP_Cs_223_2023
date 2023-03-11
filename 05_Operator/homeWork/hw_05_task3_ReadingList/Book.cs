using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public class Book
    {
        public string? Author { get; set; }
        public string? Title { get; set; }
        public BookTypesEnum BookType { get; set; }
        public DateOnly ReleaseDate { get; set; }
        private int? _pages;
        public int? Pages 
        { 
            get { return _pages; }
            set 
            {
                if (value != null)
                {
                    if (value < 1)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value),
                            message: "Book must have at least 1 page");
                    }
                    _pages = value;
                }
                else 
                {
                    _pages = null;
                }
            } 
        }

        public override bool Equals(object? obj)
        {
            return this.ToString().ToLower() == obj?.ToString()?.ToLower();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Book? left, Book? right) 
        {
            return left.Equals(right);
        }

        public static bool operator !=(Book left, Book right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return $"{Author}; {Title}; {ReleaseDate.Year}; {Pages}p.";
        }

    }
}
