//TODO: You need to create a game that consists of asking the player what's the result of a math question (i.e. 9 x 9 = ?), collecting the input and adding a point in case of a correct answer.
//TODO:A game needs to have at least 5 questions.
//TODO:The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
//TODO:Users should be presented with a menu to choose an operation
//TODO:You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games. (No storage after closing the program)
int i = 0;

do
{
    while (!GameTitle())

    {
        
    }
    Console.WriteLine(i);
    i++;
} while (i != 5);

Console.WriteLine("Game over");

    bool GameTitle()
    {
        Console.WriteLine("Please select a difficulty");
        Console.WriteLine("1 - Easy");
        Console.WriteLine("2 - Normal");
        Console.WriteLine("3 - Hard");
        if (int.TryParse(Console.ReadLine(), out int userDifficulty )&& userDifficulty is > 0 and < 4)
            {
                return true;
            }
        Thread.Sleep(400);
        Console.WriteLine("Please select a valid number");
        Thread.Sleep(2000);
        Console.Clear();
        return false;
    }

    bool VerifyDivision(int a, int b)
    {
        if (a % b == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

/*int[] GameLogic(string choosenOperator,int difficultyLevel = 3)
{

    switch (difficultyLevel)
    {
        case 1:

            break;
        case 2:
            //Normal
            break;
        case 3:
            //Hard
            break;
    }
}
*/
//bool intChecker(string input);

