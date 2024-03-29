using Assignment.DbContext;
using Assignment.Entities;
using Assignment.Extensions;
using Assignment.Repositories;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContext<Speaker> dbContext = new DbContext<Speaker> ();    
            IRepository<Speaker> repository = new Repository<Speaker>(dbContext);
            Data data = new Data();

            var speaker = new Speaker()
            {
                FirstName = "Antoan",
                LastName = "Georgiev",
                Email = "a.georgiev@gmail.com",
                HasBlog = true,
                BlogURL = "www.myblog.com",
                Browser = new WebBrowser("Internet Explorer", 2),
                Employer = "Teodor",
                RegistrationFee = 3,
                Certifications = new List<string>()
            };

            var session = new Session ("title", "description" );
            speaker.Sessions.Add(session);


            speaker.Register(repository, data, speaker.Browser);
        }
    }
}
