//TODO: You need to create a game that consists of asking the player what's the result of a math question (i.e. 9 x 9 = ?), collecting the input and adding a point in case of a correct answer.
//TODO:A game needs to have at least 5 questions.
//TODO:The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
//TODO:Users should be presented with a menu to choose an operation
//TODO:You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games. (No storage after closing the program)
while (!GameTitle());
Console.WriteLine("Game over");

    bool GameTitle()
    {
        bool OperatorSelector(out int selectedOperator)
                  {
                      Console.WriteLine("Please select an operator");
                      Console.WriteLine("1 - Addition");
                      Console.WriteLine("2 - Subtraction");
                      Console.WriteLine("3 - Multiplication");
                      Console.WriteLine("4 - Division");
                      if (int.TryParse(Console.ReadLine(), out int userOperator) && userOperator is > 0 and < 5)
                      {
                          selectedOperator = userOperator;
                          return true;
                      }
                      selectedOperator = 0;
                      Console.WriteLine("Please select a valid operator");
                      return false;
                  }

        //Difficulty selector

        
        Console.WriteLine("Please select a difficulty");
        Console.WriteLine("1 - Easy");
        Console.WriteLine("2 - Normal");
        Console.WriteLine("3 - Hard");
        if (int.TryParse(Console.ReadLine(), out int userDifficulty )&& userDifficulty is > 0 and < 4)
        {
            
            
            int selectedOperator = 0;
            while (!OperatorSelector(out selectedOperator));
            for (int j = 0; j <5 ; j++)
            {
                GameLogic(selectedOperator,userDifficulty);
            }
            
            return true; 
        }
        Thread.Sleep(400);
        Console.WriteLine("Please select a valid number");
        Thread.Sleep(2000);
        Console.Clear();
        return false;
    }
bool GameLogic(int choosenOperator,int difficultyLevel)
{
    bool IsExactDivision(int a, int b)
     {
         return a % b == 0;
     }
    
    int maximumNumber = 100;
    //Difficulty
    switch (difficultyLevel)
    {
        case 1:
            //Easy = Up to 10
            maximumNumber = 10;
            break;
        case 2:
            //Normal = Up to 25
            maximumNumber = 25;
            break;
        case 3:
            //Hard = Up to 100
            break;
    }

    Random numberPicker = new Random();
    int number1= numberPicker.Next(maximumNumber);
    int number2 = numberPicker.Next(maximumNumber);
    if (choosenOperator ==4)
    {
        do
        {
            number1 = numberPicker.Next(1,maximumNumber);
            number2 = numberPicker.Next(1,maximumNumber);
        }
        while(!IsExactDivision(number1, number2));
    }
    else if(choosenOperator ==2 && number1 - number2 <0)
    {
        //Swapping value for easiest and fastest resolution
        (number2, number1) = (number1, number2);
    }
    //Operator
    int result = 0;
    string question="";
    string[] operatorArray = ["+", "-", "*", "/"];
    result = choosenOperator 
        switch
    {
        1 => number1 + number2,
        2 => number1 - number2,
        3 => number1 * number2,
        4 => number1 / number2,
        _ => result = 0,
    };
    question = $"{number1} {operatorArray[choosenOperator - 1]} {number2} = ";
   
    //Console.WriteLine(result);
    int userChoice;
    do
    {
        Console.Write(question);
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            break;
        }
        
    } while (true);

    if (userChoice == result)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Incorrect! Answer was {result}");
    }
    return true;
}