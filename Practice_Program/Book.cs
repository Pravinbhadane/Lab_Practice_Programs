using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class Book
    {
        int book_id;
        string book_name;
        int price;
        int count = 0;
        Book[] book = new Book[100];
        public Book()
        {

        }
        public Book(int book_id, string book_name, int price)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.price = price;

        }
        public void InsertBook()
        {
            Console.WriteLine("Enter How many book you want to insert");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter Book Id");

                int bid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter book name");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter Price");
                int price = Convert.ToInt32(Console.ReadLine());
                book[count] = new Book(bid, bname, price);
                count++;

            }
        }
        public void ShowBook()
        {
            for (int i = 0; i < count; i++)
            {
                if (book[i] != null)
                {
                    Console.WriteLine(book[i]);
                }
            }

        }
        public void SearchById()
        {
            Book b = new Book();
            Console.WriteLine("Enter ID for Search");
            int bid = int.Parse(Console.ReadLine());
            bool isPresent = false;

            for (int i = 0;i < count;i++)
            {
                if (book[i] != null)
                {
                    if (book[i].book_id == bid)
                    {
                        isPresent = true;
                        b = book[i];
                        break;
                    }
                }
            }

            if (isPresent)
            {
                Console.WriteLine(b);
            }
        }

        public void UpdateBook()
        {
            Console.WriteLine("Enter Id for update");
            int bid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Price");
            int price = Convert.ToInt32(Console.ReadLine());
            bool isUpdate = false;

            for(int i = 0; i< count; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].book_id == bid)
                    {
                        book[i].price = price;
                        isUpdate = true;
                    }
                }
            }
            if(isUpdate)
            {
                Console.WriteLine("Price Updated Successfully");
            }
        }

        public void DeleteBook()
        {
            Console.WriteLine("ENter Book Id To delete::");
            int bid = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].book_id == bid)
                    {

                        book[i] = book[i + 1];
                        Console.WriteLine("Book Deleted");
                    }
                }
                count--;
                book[count] = null;
            }
        }

        public override string ToString()
        {
            return $"{book_id}\n{book_name}\n{price}";
        }

        static void Main(string[] args)
        {
          
            
            Book b = new Book();
         
                Console.WriteLine(" Select Option");
                Console.WriteLine("1 Insert Book");
                Console.WriteLine("2 Update Book By ID");
                Console.WriteLine("3 Show Books");
                Console.WriteLine("4 Search By Id");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        b.InsertBook();
                        break;
                    case 2:
                        b.UpdateBook();
                        break;
                    case 3:
                        b.ShowBook();
                        break;
                    case 4:
                        b.SearchById();
                        break;
                }

        }
    }   

}
