using Inlämning_2_EntityFramwork.Models;
using Inlämning_2_EntityFramwork.Utils;

namespace Inlämning_2_EntityFramwork
{
    public class Menu
    {
        public void startMenu()
        {
            ContentCreator addContent = new();
            addContent.ContentCreation();


            Console.WriteLine("Välkommen! ");

            Console.WriteLine("Vad vill du göra?");

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int caseDecide);

            switch (caseDecide)
            {
                case 1:
                    AddCharacter();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                default:
                    break;
            }
        }
        public void AddCharacter()
        {
            using (var addCharacter = new DBClass())
            {
                Console.WriteLine("Vem vill du lägga till, ange namn: ");
                var addCharacterName = Console.ReadLine();

                Console.WriteLine("Ange efternamn: ");
                var addCharacterLastname = Console.ReadLine();

                Console.WriteLine("Ange födelseår: ");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out int addCharacterBirthy);
        

                Console.WriteLine("Ange dödsår: ");
                string userInput3 = Console.ReadLine();
                int.TryParse(userInput3, out int addCharacterDeathy);

                Console.WriteLine("Ange Pappa: ");
                var addCharacterFather = Console.ReadLine();

                Console.WriteLine("Ange Mamma: ");
                var addCharacterMother = Console.ReadLine();

                Person b = new Person()
                {
                    
                    Name = addCharacterName,
                    LastName = addCharacterLastname,
                    BirthYear = addCharacterBirthy,
                    DeathYear = addCharacterDeathy,
                    Father = addCharacterFather,
                    Mother = addCharacterMother,
                };

                addCharacter.People.Add(b);
                addCharacter.SaveChanges();
                



            }
            
            
                  
        }
        public void UpdateCharacter()
        {
        }
        public void RemoveCharacter()
        {

        } 
        public void ShowCharacters()
        {

        }
    }
}