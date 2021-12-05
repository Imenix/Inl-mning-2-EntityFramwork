namespace Inlämning_2_EntityFramwork.Utils;
public class ContentCreator
{

    public void ContentCreation()
    {

        using (var db = new DBClass())
        {
            db.People.Add(new Models.Person()
            {   
                /*Id = 2*/
                Name = "Tommy",
                LastName = "Shelby",
                BirthYear = 1892,
                DeathYear = 1946,
                Father = "Bla",
                Mother = "Bleh",
            });
            db.SaveChanges();
        }
        using (var db = new DBClass())
        {
            db.People.Add(new Models.Person()
            {
                /*Id = 2*/
                Name = "Polly",
                LastName = "Shelby",
                BirthYear = 1892,
                DeathYear = 1946,
                Father = "Bla",
                Mother = "Bleh",
            });
            db.SaveChanges();
        }
        using (var db = new DBClass())
        {
            db.People.Add(new Models.Person()
            {
                /*Id = 2*/
                Name = "John",
                LastName = "Shelby",
                BirthYear = 1892,
                DeathYear = 1946,
                Father = "Bla",
                Mother = "Bleh",
            });
            db.SaveChanges();
        }
        using (var db = new DBClass())
        {
            db.People.Add(new Models.Person()
            {
                /*Id = 2*/
                Name = "Charlie",
                LastName = "Shelby",
                BirthYear = 1892,
                DeathYear = 1946,
                Father = "Bla",
                Mother = "Bleh",
            });
            db.SaveChanges();
        }
        using (var db = new DBClass())
        {
            db.People.Add(new Models.Person()
            {
                /*Id = 2*/
                Name = "Arthur Jr",
                LastName = "Shelby",
                BirthYear = 1892,
                DeathYear = 1946,
                Father = "Bla",
                Mother = "Bleh",
            });
            db.SaveChanges();
        }
    }
}

      
    
