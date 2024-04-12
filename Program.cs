//Programmer: Brian Lee
//Date: 4/12/2024

//Title: CSI 120 Lecture 2 Notes

namespace CSI_120_Lecture_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserInput();

        }//end of main

        public static void UserInput()
        {
            string userName;
            string dateInput;
            string titleInput;

            Console.Write("What is your name? ");
            userName = Console.ReadLine();

            string dateFormat = "mm/dd/yyyy";
            bool validInput = false;
            while (!validInput) {
                Console.Write("What is the date? (mm/dd/yyy)");
                dateInput = Console.ReadLine();
                if (DateTime.TryParseExact(dateInput, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime date)) ///from chatgpt
                {
                    validInput = true;

                }
                else
                {
                    Console.WriteLine("Invalid format. Please write date in mm/dd/yyyy");
                }
            }


            Console.WriteLine("What is the assignment called?");
            titleInput = Console.ReadLine();


            Console.WriteLine("//Results");
            Console.WriteLine(userName);
            Console.WriteLine(dateInput);
            Console.WriteLine(titleInput);

        }//end of User Input
    }//end of class
}//end of namespace
