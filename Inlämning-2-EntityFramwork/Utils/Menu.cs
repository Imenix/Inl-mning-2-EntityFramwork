namespace Inlämning_2_EntityFramwork
{
    public class Menu
    {
        public void startMenu()
        {
            Console.WriteLine("Välkommen! ");

            Console.WriteLine("Vad vill du göra?");

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int caseDecide);

            switch (caseDecide)
            {
                case 1:
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
    }
}