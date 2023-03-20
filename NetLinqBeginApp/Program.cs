using ExampleClassLibrary;

var users = new List<User>()
{
    new("Sam", 23),
    new("Bob", 31),
    new("Tim", 29),
    new("Joe", 42),
    new("Leo", 35),
};

var usersResO = from u in users
                select u.Name;

var usersResM = users.Select(u => u.Name).ToList();

Console.WriteLine(usersResM.GetType());

var usersYearO = from u in users
                 select new
                 {
                     FirstName = u.Name,
                     Year = DateTime.Now.Year - u.Age,
                 };

var usersYearM = users.Select(u => new
                        {
                            FirstName = u.Name,
                            Year = DateTime.Now.Year - u.Age,
                        });

var usersYearLets = from u in users
                    let name = "Mr." + u.Name
                    let year = DateTime.Now.Year - u.Age
                    select new
                    {
                        FirstName = name,
                        Year = year,
                    };

foreach(var user in usersYearLets)
    Console.WriteLine($"User name {user.FirstName}, year: {user.Year}");



/*
void LinqBegin()
{
    string[] users = { "Bob", "Tom", "Joe", "Tim", "Sam" };

    //var usersT = new List<string>();

    //foreach(var user in users)
    //    if(user.ToUpper().StartsWith("T"))
    //        usersT.Add(user);

    //foreach(var user in usersT)
    //    Console.WriteLine(user);

    // LINQ 

    var usersTO = from user in users
                  where user.ToUpper().StartsWith("T")
                  orderby user
                  select user;

    var usersTM = users.Where(user => user.ToUpper().StartsWith("T"))
                       .OrderBy(user => user);

    foreach (var user in usersTM)
        Console.WriteLine(user);
}
*/