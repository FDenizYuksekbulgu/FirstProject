Console.WriteLine("------------------------GUESS NUMBER---------------------------");

//In this step we introduce the rules of the game to the player.

Random randomly = new Random();
int randomNumber = randomly.Next(1, 101);
int right = 5;
Console.WriteLine("Welcome To Number Guessing Game!");
Console.WriteLine($"Let you guess 'Which number am I?' Say a number from 1 to 100\nYou have {right} rights. Have a good luck!");



//In this step, we ask the player to enter a guess number.

while (right > 0)
{
    Console.WriteLine("\nPlease enter your estimated number: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber == randomNumber)
    {
        Console.WriteLine("Congratulations.. You are right!");
        break;
    }
    else if (userNumber < randomNumber)
    {
        Console.WriteLine("Please, try a greater number!");
    }
    else
    {
        Console.WriteLine("Please, try a smaller number!");
    }

    //In this step, we reduce the user's rights.
    right--;
    Console.WriteLine($"Your remaining rights: {right}");

    if (right == 0)
    {
        Console.WriteLine("Unfortunately, your guess right is finished!");
        Console.WriteLine($"Correct Number: {randomNumber}");
    }


}
Console.WriteLine("GAME OVER!\n You can restart the game to play again!..");


Console.WriteLine("-----------------------------CALCULATOR------------------------------");

//CALCULATOR

//The first number is taken from the user
Console.WriteLine("Please enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//The action to be operation is taken from the user
Console.WriteLine("Please select the operation you want to do: \n" +
    "For Addition           (+) press 1 \n" +
    "For Subtraction        (-) press 2  \n" +
    "For Multiplication     (*) press 3   \n" +
    "For Division           (/) press 4");
Console.WriteLine("Enter your choice: ");
int operation = Convert.ToInt32(Console.ReadLine());

// The second number is taken from the user
Console.WriteLine("Please enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// The operation is performed and the result is printed.
int result;
switch (operation)
{
    case 1:
        result = firstNumber + secondNumber;
        Console.WriteLine($"\nResult: {firstNumber} + {secondNumber} = {result}");
        break;

    case 2:
        result = firstNumber - secondNumber;
        Console.WriteLine($"\nResult: {firstNumber} - {secondNumber} = {result}");
        break;

    case 3:
        result = firstNumber * secondNumber;
        Console.WriteLine($"\nResult: {firstNumber} * {secondNumber} = {result}");
        break;

    case 4:
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"\nResult: {firstNumber} / {secondNumber} = {result}");
        }
        else
        {
            Console.WriteLine("\nError: Division by zero is not allowed!");
        }
        break;

    default:
        Console.WriteLine("\nInvalid choice. Please select a number between 1 and 4.");
        break;
}

Console.WriteLine("\nThank you for using my calculator!");


Console.WriteLine("-------------------------------AVARAGE CALCULATOR-------------------------------");

//Gets the grades of three exams from the user.
//Checks if the grades are valid (must be between 0 and 100).

Console.WriteLine("Birinci ders notunuu giriniz (0-100): ");
double not1 = Convert.ToDouble(Console.ReadLine());
if (not1 < 0 || not1 > 100) { Console.WriteLine("Geçersiz not girdiniz!"); return; }

Console.WriteLine("İkinci ders notunu giriniz (0-100): ");
double not2 = Convert.ToDouble(Console.ReadLine());
if (not2 < 0 || not2 > 100) { Console.WriteLine("Geçersiz not girdiniz!"); return; }

Console.WriteLine("Üçüncü ders notunu giriniz (0-100): ");
double not3 = Convert.ToDouble(Console.ReadLine());
if (not3 < 0 || not3 > 100) { Console.WriteLine("Geçersiz not girdiniz!"); return; }

//Determines the letter grade with the average value and prints it on the screen.

double ortalama = (not1 + not2 + not3) / 3;
Console.WriteLine($"Ortalama: {ortalama}");

if (ortalama >= 90) Console.WriteLine("Harf Notu: AA");
else if (ortalama >= 85) Console.WriteLine("Harf Notu: BA");
else if (ortalama >= 80) Console.WriteLine("Harf Notu: BB");
else if (ortalama >= 75) Console.WriteLine("Harf Notu: CB");
else if (ortalama >= 70) Console.WriteLine("Harf Notu: CC");
else if (ortalama >= 65) Console.WriteLine("Harf Notu: DC");
else if (ortalama >= 60) Console.WriteLine("Harf Notu: DD");
else if (ortalama >= 55) Console.WriteLine("Harf Notu: FD");
else Console.WriteLine("Harf Notu: FF");
