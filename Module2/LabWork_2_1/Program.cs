using System;

namespace LabWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine();
        }
    }

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    interface ILibraryUser
    {
        void AddBook();
        void RemoveBook();
        void BookInfo();
        void BooksCount();

    }


    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser
    {

        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            private set
            {
                FirstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public int Phone { get; set; }
        public int BookLimit
        {
            get
            {
                return BookLimit;
            }
            set
            {
                BookLimit = value;
            }
        }

        // 4) declare field (bookList) as a string array
        public string[] bookList;

        // 5) declare indexer BookList for array bookList
        public string this[int index]
        {
            get => bookList[index];
            set => bookList[index] = value;
        }

        // 6) declare constructors: default and parameter
        public LibraryUser()
        {

        }
        public LibraryUser(string FirstName, string LastName, int Id, int Phone, int BookLimit, int arraySize)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
            this.Phone = Phone;
            this.BookLimit = BookLimit;
            this.bookList = new string[arraySize];
        }

        // 7) declare methods: 

        //AddBook() – add new book to array bookList
        public void AddBook(string book)
        {
            for (int i = 0; i < bookList.Length; i++)
            {

                if (bookList[i] == null)
                {
                    bookList[i] = book;
                    break;
                }

            }
        }
        //RemoveBook() – remove book from array bookList
        public void RemoveBook(int index)
        {

            for (int i = index; i < bookList.Length - 1; i++)
            {
                bookList[i] = bookList[i + 1];
            }
            bookList[bookList.Length - 1] = null;
        }

        //BookInfo() – returns book info by index
        public void BookInfo()
        {

        }


        //BooksCout() – returns current count of books
    }
}
