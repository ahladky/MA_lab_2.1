using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

     interface ILibraryUser
     {
        void AddBook(string nameBook);
        void RemoveBook(string nameBook);
        string BookInfo(int indexBook);
        int BooksCount();

    }



    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser : ILibraryUser
    {

        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)

        // 4) declare field (bookList) as a string array


        // 5) declare indexer BookList for array bookList

        // 6) declare constructors: default and parameter

       public string FirstName { get; }
       public string LastName { get; }
       public int Id { get; }
       public string Phone { get; set; }
       public int BookLimit { get; }
       private string[] bookList { get; set; }
       private int BookList { get; set; }      


        public void AddBook(string nameBook)
        {
            if (BookList == BookLimit )
            {
                Console.WriteLine("Not do (over limit)!");
                return;
            }
            if (BookList < BookLimit)
            {
                for (int i = 0; i< bookList.Length;i++)
                {
                    if(bookList[i] == "" | bookList[i] == null)
                    {
                        bookList[i] = nameBook;
                        BookList++;
                        break;
                    }
                }
            }
        }

        public string BookInfo(int indexBook)
        {
            string bN = bookList[indexBook];
            return bN;
        }

        public int BooksCount()
        {
            return BookList;
        }

        public void RemoveBook(string nameBook)
        {
         for (int i = 0; i < bookList.Length; i++)
            {
               if(bookList[i] == nameBook)
                {
                    bookList[i] = null;
                    break;
                }
            }
            BookList--;
        }

        public LibraryUser() 
        {
            BookList = 0;
            BookLimit = 1;
            bookList = new string[1];
        }
        public LibraryUser(string firstName, string lastName, string phone, int bookLimit)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BookLimit = bookLimit;
            BookList = 0;
            bookList = new string[bookLimit];
        }

    }



    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books

}
