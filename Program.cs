using System;

namespace QADEMO
{
    public class UserData
    {
        public static string[] names = {"Aria", "Budi", "Citra", "Dewi", "Eka", "Fitri", "Gita", "Hadi", "Indra", "Joko", "Kartika", "Laras",
               "Mega", "Nadia", "Oscar", "Putri", "Rizky", "Sinta", "Tono", "Umi", "Vera", "Wira", "Xena", "Yuni", "Zara","Wijaya", "Santoso", "Purnama", "Kusuma", "Sari", "Hartono", "Mulyadi", "Widjaja", "Saputra", "Lestari",
              "Yulianto", "Gunawan", "Budiman", "Siregar", "Sulistyo", "Pranowo", "Kurniawan", "Halim", "Santoso"};
    } // this is the list of our data names

    public class TemplateText
    {
        public static string WhenDataFound(string theData)
        {
            return $"------------------> {theData} is MATCH";
        }
        public static string WhenNotFound(string theData)
        {
            return $"{theData} is not match";
        }
    } // this is template text we want to show when data found/not found
    
    public class Program
    {
        static void Main(string[] args)
        {
            //SingleMethodOnly.runTheProgram("Oscar", UserData.names);
            MultipleMethods.runTheProgram("Oscar", UserData.names);
        }
    } // this class is where the program will be run

    public class SingleMethodOnly // all programs done in single class
    {
        public static void runTheProgram(string findThisName,string[] userList)
        {
            foreach (var item in userList)
            {
                // compare defined name with name from the list
                if (findThisName == item)
                {
                    // if true or names are equally the same then do this
                    DisplayOutput.DisplayToConsole(TemplateText.WhenDataFound(findThisName));
                }
                // if false then do this instead
                else
                {
                    DisplayOutput.DisplayToConsole(TemplateText.WhenNotFound(item));
                }

            }
        }
    }

    public class MultipleMethods // this program is collections of functions
    {
        public static void runTheProgram(string findThis, string[] userData)
        {
            Looping.ForeachLoop(findThis, UserData.names);
        }
    }

    public class DisplayOutput // this to show the output into console
    {
       public static void DisplayToConsole (string userInput)
        {
            Console.WriteLine(userInput);
        }
    }

    public class ProgramLogic
    {
        public static void NameFinder(string findThisName, string nameToCompare)
        {
            // compare defined name with name from the list
            if (findThisName == nameToCompare)
            {
                // if true or names are equally the same then do this
                DisplayOutput.DisplayToConsole(TemplateText.WhenDataFound(findThisName));
            }
            // if false then do this instead
            else
            {
                DisplayOutput.DisplayToConsole (TemplateText.WhenNotFound(nameToCompare));
            }
        }
    } // this is the logic for MultipleMethods

    public class Looping
    {
        public static void ForLoop(int maxLoop,string StringToLoop )
        {
            for (int i = 1; i < maxLoop; i++)
            {
                DisplayOutput.DisplayToConsole($"No.{i} - {StringToLoop}");
            }
        }
        
        public static void ForeachLoop(string findThisName,string[] ListFromUser)
        {
            foreach (string item in ListFromUser) 
            {
                ProgramLogic.NameFinder(findThisName,item);
            }
        }

    public class GetUserInput
    {
        public static string FromConsole(string userInput)
        {
            DisplayOutput.DisplayToConsole(userInput);
            return Console.ReadLine();
        }
    }

    } // this for looping the data

}
