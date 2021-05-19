using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============1=================");
            var books = SampleData.Books
                .Select(b => new {b.Isbn,b.Title});
            foreach (var s in books)
                Console.WriteLine(s);
            Console.WriteLine("================2================");
          
            IEnumerable<string> books2 = SampleData.Books.Where(b =>b.Price>25 )
                .Select(b => $"{b.Isbn}:{b.Title}:{b.Price}$")
                .ToList().Take(3);
            foreach (string s in books2)
                Console.WriteLine(s);
            Console.WriteLine("================3-1================");

            IEnumerable<string> books3 = SampleData.Books
                .Select(b => $"{b.Title}:{b.Publisher.Name}");
            foreach (string s in books3)
                Console.WriteLine(s);
            Console.WriteLine("================3-2================");
            var books33 =
                from b in SampleData.Books
                select new { b.Title, b.Publisher.Name };
            foreach (var s in books33)
                Console.WriteLine(s);
            Console.WriteLine("================4================");
            int count = SampleData.Books.Where(b => b.Price > 20).Count();
            Console.WriteLine($"number of books costs >20 is :{count}");
            Console.WriteLine("================5================");
            var books5 = SampleData.Books
                .OrderBy(b => b.Subject.Name)
                .ThenByDescending(b => b.Price)
                .Select(b => new{b.Title,b.Subject.Name});
            foreach (var s in books5)
                Console.WriteLine(s);
            Console.WriteLine("================6-1================");
            var query =
                from sub in SampleData.Subjects
                select new
                {
                    SubjectName = sub.Name,
                    books =
                        from b in SampleData.Books
                        where b.Subject.Name == sub.Name
                        select new { b.Title, b.Price }
                };

            foreach (var item in query)
            {
                Console.WriteLine($"Subject : {item.SubjectName}");

                foreach (var b in item.books)
                {
                    Console.WriteLine($"book: {b.Title} \t price: {b.Price}");
                }
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("================6-2================");
            var query2 =
                from b in SampleData.Books
                group b by b.Subject.Name;

            foreach (var gr in query2)
            {
                Console.WriteLine($"Subject : {gr.Key}");

                foreach (var b in gr)
                {
                    Console.WriteLine($"Course: {b.Title} \t price {b.Price}");
                }
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("================7================");
            var books7 = SampleData.GetBooks().OfType<Book>().Select(b => new { b.Isbn, b.Title });
            foreach (var s in books7)
                Console.WriteLine(s);

            Console.WriteLine("================8================");
            var query3 =
               from b in SampleData.Books
               group b by new {subject= b.Subject.Name ,publisher= b.Publisher.Name} ;

            foreach (var gr in query3)
            {
                Console.WriteLine($"Subject : {gr.Key.subject} ||\t Publisher :{gr.Key.publisher}");

                foreach (var b in gr)
                {
                    Console.WriteLine($"Course: {b.Title} \t price {b.Price}");
                }
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
