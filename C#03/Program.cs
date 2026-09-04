using Microsoft.VisualBasic.FileIO;

namespace C_03
{
    internal class Program
    {
        #region q10 
        //static void PrintFirstBook(string[] arr  ) 
        //{
        //    if (arr[0] == null || arr[0] == "" || arr[0] == " ")
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine(arr[0]);
        //    }
        //}
        #endregion 
        static void Main(string[] args)
        {
            #region q1
            //int pages = 464;
            //bool isAvailable = true; 
            //if ( isAvailable== true && pages > 300)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region q2
            //string title = "Refactoring";
            //string sol = title switch
            //{
            //    "Clean Code" => "Great choice!",
            //    "Refactoring" => "Nice pick!",
            //    _ => "Never heard of it"
            //};
            //Console.WriteLine(sol);
            #endregion

            #region q3 
            //int pages = 464;
            //string sol = (pages > 300) ? "Long Book" : "Short Book";
            //Console.WriteLine(sol);
            #endregion

            #region q4 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for ( int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}){books[i]}");
            //}
            #endregion

            #region q5 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0; 
            //while (books[i]!= null)
            //{
            //    Console.WriteLine($"{i + 1}){books[i]}");
            //    i++;
            //}
            #endregion

            #region q6 
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i <=2);
            #endregion

            #region q7
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //foreach (string book in books)
            //{
            //    i++;
            //    Console.WriteLine($"{i}){book}");
            //}
            #endregion

            #region q8 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"{i+1}){books[i]}");
            //}
            #endregion

            #region q9 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int j = 0;
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    j++;
            //        Console.WriteLine($"{j}){books[i]}");
            //}
            #endregion

            #region q10 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //PrintFirstBook(books);
            #endregion
        }
    }
}
