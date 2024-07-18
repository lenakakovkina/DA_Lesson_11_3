List<string> guestsKids = new List<string>();
List<string> guestsAdults = new List<string>();
List<string> guestsOld = new List<string>();
string userInputName = "";
string userInputAge;
int userInputAgeToInt;
while (userInputName != "stop")
{
    Console.WriteLine("\nWhat is your name? In case there is no more guests print stop");
    userInputName = Console.ReadLine();

    if (userInputName != "stop")
    {
   
        Console.WriteLine("\nWhat is your full age?");

        userInputAge = Console.ReadLine();
        bool isValidInput = int.TryParse(userInputAge, out userInputAgeToInt);

        if (isValidInput)
        {
            if (userInputAgeToInt > 0 && userInputAgeToInt < 18)
            {
                Console.WriteLine($"\nHi {userInputName}! Go to room for kids");
                guestsKids.Add(userInputName);
            }
            else if (userInputAgeToInt >= 18 && userInputAgeToInt < 50)
            {
                Console.WriteLine($"\nHi {userInputName}! Go to room for adults");
                guestsAdults.Add(userInputName);
            }
            else if (userInputAgeToInt > 50 && userInputAgeToInt < 120)
            {
                Console.WriteLine($"\nHi {userInputName}! Go to room for old people");
                guestsOld.Add(userInputName);
            }

        }
        else
        {
            Console.WriteLine($"Invalid input. Please re-enter name and age one more time");
                    }
    }
    else if (userInputName == "stop")
    {
        int numberOfKids = guestsKids.Count;
        int numberOfAdults = guestsAdults.Count;
        int numberOfOld = guestsOld.Count;

        Console.WriteLine($"\nAll are in place.There are {numberOfKids+ numberOfAdults+ numberOfOld} people.");
 
        Console.WriteLine($"\n In room for kids we have: {numberOfKids} persons.\n Here is the list of guests:");
        for (int i = 0; i < numberOfKids; i++)
        {
            Console.WriteLine($"- {guestsKids[i]}");
        }
      
        Console.WriteLine($"\n In room for adults we have: {numberOfAdults} persons.\n Here is the list of guests:");
        for (int i = 0; i < numberOfAdults; i++)
        {
            Console.WriteLine($"- {guestsAdults[i]}");
        }
  
        Console.WriteLine($"\n In room for old we have: {numberOfOld} persons.\n Here is the list of guests:");
        for (int i = 0; i < numberOfOld; i++)
        {
            Console.WriteLine($"- {guestsOld[i]}");
        }

        break;
    }
}