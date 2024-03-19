using Assignment.Classes;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Erin Morgenstern"
            };
            Author author2 = new Author()
            {
                Name = "George R.R. Martin"
            };

            List<Author> authors = new List<Author>() { author1, author2 };

            Book book1 = new Book()
            {
                Title = "The Night Circus",
                Author = author1.Name
            };
            Book book2 = new Book()
            {
                Title = "Game of thrones",
                Author = author2.Name
            };

            List<Book> books = new List<Book> { book1, book2 };


            //Join method
            var join = books.Join(authors,
                book => book.Author,
                author => author.Name,
                (book, author) => new { BookTitle = book.Title, AuthorName = author.Name });

            //GroupJoin method
            var groupJoin2 = books.GroupJoin(authors,
                book => book.Author,
                author => author.Name,
                (book, author) => new { BookTitle = book.Title, Authors = author });

            //foreach (var b in groupJoin2)
            //{
            //    Console.WriteLine($"Book Title: {b.BookTitle}");
            //    foreach (var author in b.Authors)
            //    {
            //        Console.WriteLine($"Author: {author.Name}");
            //    }
            //}


            //Zip method
            List<string> firstNames = new List<string> { "John ", "Emily ", "Michael " };
            List<string> lastNames = new List<string> { "Smith", "Johson", "Brown" };
            var fullNames = firstNames.Zip(lastNames, (f, l) => f + l);

            //Group By
            var group = books.GroupBy(b => b.Author);

            //Concat
            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers2 = new List<int> { 5, 6, 7, 8 };
            var concat = numbers1.Concat(numbers2).ToList();

            //Union
            var union = numbers1.Union(numbers2).ToList();

            //Intersect
            var intersect = numbers1.Intersect(numbers2).ToList();

            //Except
            var except = numbers1.Except(numbers2).ToList();


            //OfType
            var fruits = new List<string>();
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Kiwi");
            fruits.Add("Strawberry");

            IEnumerable<string> query1 = fruits.OfType<string>();
            IEnumerable<string> query2 = fruits.OfType<string>()
                .Where(fruit => fruit.ToLower().Contains("w"));

            //Cast
            double x = 12.5;
            int y;
            y = (int)x;

            //ToList
            int[] array1 = { 1, 2, 3, 4 };
            var query3 = array1
                .OrderByDescending(x => x)
                .ToList();

            //ToArray
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            var query4 = list1
                .OrderByDescending(x => x)
                .ToArray();

            //ToDictionary
            Package package1 = new Package()
            {
                Owner = "Gosho",
                Kg = 32,
                TrackingNum = "732931033221"
            };
            Package package2 = new Package()
            {
                Owner = "Pesho",
                Kg = 22,
                TrackingNum = "329841113212"
            };
            List<Package> packages = new List<Package>() { package1, package2 };
            Dictionary<string, Package> dictionary = packages.ToDictionary(p => p.TrackingNum);

            //ToLookup
            ILookup<char, string> lookup = packages
                .ToLookup(p => p.Owner[0], p => p.Owner + " " + p.TrackingNum);

            //AsEnumerable - convert/cast specific types of given list to its IEnumerable equivalent type
            int[] numArray = { 1, 2, 3, 4, 5 };
            var numArrayAsEnumerable = numArray.AsEnumerable();

            //AsQueryable - convert input list elements to IQueryable<T> list
            Student student1 = new Student()
            {
                Name = "Johanna Hayes",
                Gender = "Female"
            };
            Student student2 = new Student()
            {
                Name = "Thomas Lindgren",
                Gender = "Male"
            };
            Student student3 = new Student()
            {
                Name = "Debbie Ellis",
                Gender = "Female"
            };
            List<Student> students = new List<Student>() { student1, student2, student3 };

            IQueryable<Student> studentsQuery = students
                .AsQueryable()
                .Where(s => s.Name.Contains("o")); //Johanna Hayes, Thomas Lindgren

            //Count - returns int
            string[] vegetables = { "tomato", "carrot", "cucumber", "potato" };
            int vegetablesCount = vegetables.Count();

            //LongCount - return long
            long vegetablesLongCount = vegetables.LongCount();

            //Min and Max
            var numbers = new List<int>() { 50, 88, 32, 250, 600, 18, 35, 101, 77 };
            int maxNum = numbers.Max();
            int minNum = numbers.Min();

            //Sum
            int sum = numbers.Sum();

            //Average
            double averageSum = numbers.Average();

            //Aggregate
            int numEven = numbers.Aggregate(0, (total, next) => next % 2 == 0 ? total + 1 : total);

            //Contains
            if (numbers.Contains(50))
            {
                //Console.WriteLine("Yes");
            }

            //Any
            var any = numbers.Any(n => n - 32 == 0); //True

            //All
            var all = numbers.All(n => n % 2 == 0); //False

            //SequenceEqual
            var names1 = new List<string>() { "Katya", "Petya", "Sonya" };
            var names2 = new List<string>() { "Katya", "Petya", "Sonya" };

            bool areEqual = names1.SequenceEqual(names2); //True

            //First and FirstOrDefault
            Author author3 = new Author()
            {
                Name = "Harper Lee"
            };
            Author author4 = new Author()
            {
                Name = "George Orwell"
            };

            authors.Add(author3);
            authors.Add(author4);

            var authorFirst = authors.First(a => a.Name.StartsWith("G")); //George R.R. Martin
            //var authorFirstOrDef = authors.FirstOrDefault(a => a.Name.StartsWith("D")); //System.NullReferenceException

            //Last and LastOrDefault
            var authorLast = authors.Last(a => a.Name.StartsWith("G")); //George Orwell
            var authorLastOrDef = authors.LastOrDefault(a => a.Name.StartsWith("D"));

            //Single and SingleOrDefault
            //var authorSingle = authors.Single(a => a.Name.StartsWith("G")); //System.InvalidOperationException
            var authorSingleOrDef = authors.LastOrDefault(a => a.Name.StartsWith("D"));

            //ElementAt and ElementAtOrDefault
            string authorElementAt = authors.ElementAt(2).Name; //Harper Lee
            //string authorElementAtOrDefault = authors.ElementAtOrDefault(10).Name; //System.NullReferenceException

            //DefaultIfEmpty
            List<int> emptyList = new List<int>();

            //foreach (int number in numbers.DefaultIfEmpty())
            //{
            //    Console.WriteLine(number);
            //}

            //Empty
            IEnumerable<string> emptyCollection = Enumerable.Empty<string>(); //emptyCollection.Count() == 0

            //Repeat
            IEnumerable<string> repeatString = Enumerable.Repeat("Hello!", 3);

            //Range
            IEnumerable<int> rangeNumbers = Enumerable.Range(1, 10);


        }
    }
}
