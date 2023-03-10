using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public class ReadingList
    {
        public string? Name { get; set; }
        private List<ReadingItem> _readingList = new List<ReadingItem>();
        public int Length { get { return _readingList.Count; } }

        public void AddReadingItem(ReadingItem readingItem) 
        {
            if (Length > 0) 
            {
                if (Exist(readingItem.Book)) 
                {
                    throw new Exception(message:"Book already exist");
                }
            }
            _readingList.Add(readingItem);
        }

        public void DeleteReadingItem(int index) 
        {
            _readingList.RemoveAt(index);
        }

        public void DeleteReadingItem(ReadingItem readingItem) 
        {
            _readingList.Remove(readingItem);
        }

        public bool Exist(Book? book) 
        {
            if (_readingList.Count > 0)
            {
                foreach (var item in _readingList)
                {
                    if (item.Book == book)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public ReadingItem this[int index] 
        {
            get 
            {
                if (index >= 0 && index < _readingList.Count) 
                {
                    return _readingList[index];
                }
                throw new IndexOutOfRangeException();
            } 
            set { _readingList[index] = value; }
        }

        public ReadingItem? this[string title] 
        {
            get 
            {
                return _readingList.Find(p => p?.Book?.Title?.ToLower() == title.ToLower());
            }
            set 
            {
                ReadingItem? found = _readingList.Find(p => p?.Book?.Title?.ToLower() == title.ToLower());
                if (found is not null) 
                {
                    found = value;
                }
            }
        }
    }
}
