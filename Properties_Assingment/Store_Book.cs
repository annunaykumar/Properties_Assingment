using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Assingment
{
    internal class Store_Book
    {
        
        private int serialNo;


        public int serialno
        {
            get { return serialno; }
            set { serialno = value; }
        }
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string Title;


        public string title
        {
            get { return title; }
            set { title = value; }
        }

        private string Author;


        public string author
        {
            get { return author; }
            set { author = value; }
        }

        private int BooksQt;


        public int booksQt
        {
            get { return booksQt; }
            set { booksQt = value; }
        }

        private int Bookprice;


        public int bookprice
        {
            get { return bookprice; }
            set { bookprice = value; }
        }

        private int Bill;


        public int bill
        {
            get { return bill; }
            set { bill = value; }
        }

        public Store_Book() { }


        public Store_Book(int serialno, string name, string title, string author, int booksQt, int bookprice, int bill)
        {
            this.serialno = serialno;
            this.name = name;
            this.title = title;
            this.Author = author;
            this.booksQt = booksQt;
            this.bookprice = bookprice;
            this.bill = bill;

        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}", serialNo, Name, Title, Author, BooksQt, Bookprice, Bill);
        }





        public static void Main()
        {
            List<Store_Book> booksdetails = new List<Store_Book>();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1. Add a new book details");
                Console.WriteLine("2. Display all Books available");
                Console.WriteLine("3. Delete currently searched Books");
                Console.WriteLine("4. Search a Book");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Store_Book newbooksdetails = new Store_Book();
                            Console.Write("Enter the SerialNo: ");
                            newbooksdetails.serialNo = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Book Name: ");
                            newbooksdetails.Name = Console.ReadLine();
                            Console.Write("Enter the Book Title Name: ");
                            newbooksdetails.Title = Console.ReadLine();
                            Console.Write("Enter the Book Author Name: ");
                            newbooksdetails.Author = Console.ReadLine();
                            Console.Write("Enter the Book Quantity : ");
                            newbooksdetails.BooksQt = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Book price : ");
                            newbooksdetails.Bookprice = int.Parse(Console.ReadLine());
                            Console.Write("Bill generated: ");
                            newbooksdetails.Bill = int.Parse(Console.ReadLine());


                            booksdetails.Add(newbooksdetails);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("All Books Details");
                            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}", "serialNo", "Name", "Tite", "Author", "BooksQt", "Bookprice", "Bill"));
                            foreach (Store_Book e in booksdetails)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.Write("Enter the serialNo to delete: ");
                            int serialNo = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Store_Book e in booksdetails)
                            {
                                if (e.serialno == serialNo)
                                {
                                    booksdetails.Remove(e);
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe serialNo does not exist!\n");
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.Write("Enter the Serial No to search: ");
                            int serialno = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Store_Book e in booksdetails)
                            {
                                if (e.serialNo == serialno)
                                {
                                    Console.WriteLine(string.Format("{0,-20}{1,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "serialNo", "Name", "Tite", "Author", "BooksQt", "Bookprice"));
                                    Console.WriteLine(e.ToString());
                                    exist = true;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe Book does not exist!\n");
                            }
                        }
                        break;



                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }
            Console.ReadKey();


        }
    }
}
