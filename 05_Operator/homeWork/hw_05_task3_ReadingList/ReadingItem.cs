using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public class ReadingItem
    {
        public Book? Book { get; set; }
        public ReadingGenresEnum Genre { get; set; }
        public ReadingStatusesEnum Status { get; set; }

        private int? _bookmarkPage;
        public int? BookmarkPage 
        {
            get { return _bookmarkPage; }
            set 
            {
                if (Book?.Pages != null) 
                {
                    if (value < 1 || value > Book?.Pages)
                    {
                        throw new ArgumentOutOfRangeException(paramName: $"{nameof(BookmarkPage)}", 
                            message: $"{nameof(BookmarkPage)} must be defined within 1...{Book?.Pages} range");
                    }
                    _bookmarkPage = value;
                }
            } 
        }

        private static (int minRate, int maxRate) _rateRange = (1,5);

        private int? _rate;
        public int? Rate 
        {
            get { return _rate; }
            set 
            {
                if (value < _rateRange.minRate || value > _rateRange.maxRate) 
                {
                    throw new ArgumentOutOfRangeException(paramName: $"{nameof(Rate)}",
                        message: $"{nameof(Rate)} must be defined within " +
                        $"{_rateRange.minRate}...{_rateRange.maxRate} range");
                }
                _rate = value;
            } 
        }

        public ReadingItem(Book book) 
        {
            Book = book;
            Status = ReadingStatusesEnum.ToRead;
        }

        public override string ToString()
        {
            return $"Book: [{Book}]; Genre:{Genre}; Status: {Status}; Bookmark: {BookmarkPage}; Rate: {Rate}";
        }
    }
}
