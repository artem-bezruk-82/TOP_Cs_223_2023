//Модуль 5
//Тема: Перегрузка операторов. Индексаторы и свойства
//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 3
//Создайте приложение «Список книг для прочтения». 
//Приложение должно позволять добавлять книги в список, удалять книги из списка,
//проверять есть ли книга в списке, и т. д. 
//Используйте механизм свойств, перегрузки операторов, индексаторов.

namespace hw_05_task3_ReadingList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ReadingItem readingItem1 = new ReadingItem(
                new Book()
                {
                    Author = "John Steinbek",
                    Title = "East of Eden",
                    ReleaseDate = new DateOnly(1952, 1, 1),
                    Pages = 960,
                    BookType = BookTypesEnum.Novel
                })
            {
                Genre = ReadingGenresEnum.Romance,
                Rate = 3
            };

            ReadingItem readingItem2 = new ReadingItem(
                new Book()
                {
                    Author = "Leo Tolstoy",
                    Title = "War and society",
                    ReleaseDate = new DateOnly(1869, 1, 1),
                    Pages = 1300,
                    BookType = BookTypesEnum.Novel
                })
            {
                Genre = ReadingGenresEnum.Romance,
                Rate = 4
            };

            ReadingItem readingItem3 = new ReadingItem(
                new Book()
                {
                    Author = "Enokh Breygel",
                    Title = "Political economy",
                    ReleaseDate = new DateOnly(1966, 1, 1),
                    Pages = 640,
                    BookType = BookTypesEnum.Treatise
                })
            {
                Genre = ReadingGenresEnum.Science,
                Rate = 3
            };

            ReadingList readingList = new ReadingList() { Name = "My Reading list" };
            readingList.AddReadingItem(readingItem1);
            readingList.AddReadingItem(readingItem2);
            readingList.AddReadingItem(readingItem3);

            readingList.Menu();

        }
    }
}