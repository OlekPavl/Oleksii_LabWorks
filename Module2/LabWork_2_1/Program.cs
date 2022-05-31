using System;

namespace LabWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) declare 2 objects. Use default and paremeter constructors
            LibraryUser user1 = new LibraryUser();
            LibraryUser user2 = new LibraryUser("Maria", "Ivanenko", "+380447777777", 10);
            Console.WriteLine("User1 " + user1.FirstName + " " + user1.LastName);
            Console.WriteLine("User2 " + user2.FirstName + " " + user2.LastName);

            // 9) do operations with books for all users: run all methods for both objects
            Console.WriteLine("User 1: add Harry Potter");
            user1.AddBook("Harry Potter");
            Console.WriteLine("User 2: add Sherlock Holmes");
            user2.AddBook("Sherlock Holmes");
            Console.WriteLine("user1.BooksCount = " + user1.BooksCount() + "; user2.BooksCount = " + user2.BooksCount());

            Console.WriteLine();
            Console.WriteLine("user2: Add Kobzar");
            user2.AddBook("Kobzar");
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());

            Console.WriteLine();
            Console.WriteLine("user2: Add Dorian Gray");
            user2.AddBook("Dorian Gray");
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("User2 books:");
            foreach (var item in user2.bookList)
            {
                if(item != null)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Remove Sherlock Holmes");
            user2.RemoveBook("Sherlock Holmes");
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());


            Console.ReadKey();
        }
    }

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    interface ILibraryUser
    {
        void AddBook(string book);
        void RemoveBook(string book);
        string BookInfo(int index);
        int BooksCount();

    }


    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser
    {

        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Id { get; private set; }
        public string Phone { get; set; }
        public int BookLimit { get; private set; }

        public static int Counter = 0;


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
            Counter++;
            this.FirstName = "FirstName";
            this.LastName = "LastName";
            this.Id = Counter;
            this.Phone = "Phone";
            this.BookLimit = 10;
            this.bookList = new string[BookLimit];

        }
        public LibraryUser(string FirstName, string LastName, string Phone, int BookLimit)
        {
            Counter++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Counter;
            this.Phone = Phone;
            this.BookLimit = BookLimit;
            this.bookList = new string[BookLimit];
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
        public void RemoveBook(string book)
        {
            int index = 0;
            bool result = false;

            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] == book)
                {
                    index = i;
                    result = true;
                }
            }

            if (result == true)
            {
                for (int i = index; i < bookList.Length - 1; i++)
                {
                    bookList[i] = bookList[i + 1];
                }
                bookList[bookList.Length - 1] = null;
            }
            else
            {
                Console.WriteLine($"There is no such book in the library");
            }


        }

        //BookInfo() – returns book info by index
        public string BookInfo(int index)
        {
            return bookList[index];
        }

        //BooksCout() – returns current count of books
        public int BooksCount()
        {
            int count = 0;

            foreach (string item in bookList)
            {
                if (item != null)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
