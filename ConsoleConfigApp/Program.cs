namespace ConsoleConfigApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Apple Tree");
            using EFDbContext eFDbContext = new EFDbContext();


            // create new data
            /*var person = new Person() { Name = "Moss", Age = 21, DateTime = new DateTime(2022, 01, 30), Hometown = "Anhui" };
            eFDbContext.Add<Person>(person);

            // save data to database
            await eFDbContext.SaveChangesAsync();*/

            var p = eFDbContext.person.First(b => b.Age > 12);
            Console.WriteLine($"person name : {p.Name}  Age: {p.Age}");

            //var personCollection = eFDbContext.person.Where(b => b.Name.Equals("Moss")).ToList();
            var personCollection = eFDbContext.person.Where(b => b.Age > 12).ToList();
            personCollection.ForEach(value =>
            {
                Console.WriteLine($"person name: {value.Name}, Age : {value.Age}");
            });
            
        }
    }
}