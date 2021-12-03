namespace Inlämning_2_EntityFramwork.Utils
    public class ContentCreator
    {
        public void ContentCreation()
        {
            
            using (var db = new DBClass())
            {
            db.People.Add(new Models.Person
            {

            });

            }
        }

      
    }
}