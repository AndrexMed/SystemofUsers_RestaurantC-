using System.Linq.Expressions;

string[] userNames = new string[5] { "", "", "", "", "" };

int arrayCurrentIndex = 0;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world!\n");

while (arrayCurrentIndex < 5)
{
    Console.WriteLine("Are you registered user? Write true, or write false to register");

    try
    {

        userType = Convert.ToBoolean(Console.ReadLine());

        if (userType == true)
        {

            Console.WriteLine("\nHello, you are a registered user?, please enter your username\n");
            string userToSearch = Console.ReadLine();

            Console.WriteLine("The user you searched is {0}", userToSearch + "\n");

            int index = Array.IndexOf(userNames, userToSearch);

            if (index == -1)
            {
                Console.WriteLine("User not found, try again or register!!\n");
            }
            else
            {
                Console.WriteLine("Welcome {0}", userNames[index]);
            }

        }
        else if (userType == false)
        {
            Console.WriteLine("Please write and remember your user name");
            userNames[arrayCurrentIndex] = Console.ReadLine();
            Console.WriteLine("\nYour user has been saved successfully\n" +
                "Your user name is {0}", userNames[arrayCurrentIndex]);
            arrayCurrentIndex++;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Options : true and false\n");
    }
}

Console.WriteLine("\nThe restaurant is full, try again next year\n");
int auxIndex = 0;
foreach (string element in userNames)
{
    Console.WriteLine("User number {0} and user name: {1}", auxIndex, userNames[auxIndex]);
    auxIndex++;
}
Environment.Exit(0);