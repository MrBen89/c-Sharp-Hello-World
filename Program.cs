// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// //declaration
// string myVariable;
// myVariable = "My Value";

// Console.WriteLine(myVariable);
// Console.WriteLine("Enter first number");

// String input1 = Console.ReadLine();
// int num1 = int.Parse(input1);

// Console.WriteLine("Enter second number");

// String input2 = Console.ReadLine();
// int num2 = int.Parse(input2);

// int output = num1 + num2;

// Console.WriteLine(input1 + " + " + input2 + " = " + output);

//waits for input, presumably returns the key pressed

// bool yoMamma = true;
// bool isLarge = false;

// if (yoMamma && isLarge)
// {
//     Console.WriteLine("Big Mummy");
//     //brackets optional for single line conditionals
// } else
//     Console.WriteLine("Skinny Mummy");

// switch (yoMamma)
// {
//     case true:
//         Console.WriteLine("switch big momma");
//         break;
//     case false:
//         System.Console.WriteLine("switch skinny momma");
//         break;
//     default:
//         Console.WriteLine("Momma Unknown");
//         break;
// }

using System.Reflection.Metadata;

string question1 = "What is the capital of the UK?";
string answer1 = "London";
string question2 = "What is 1 + 1?";
string answer2 = "11";
string question3 = "What is your favourite colour?";
string answer3 = "green";
int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();

if (userAnswer == answer1)
    {
        Console.WriteLine("correct");
        score ++;
    } 
else
    {
        Console.WriteLine("WROND!");
    }

Console.WriteLine(question2);
userAnswer = Console.ReadLine();

if (userAnswer == answer2)
    {
        Console.WriteLine("correct");
        score ++;
    } 
else
    {
        Console.WriteLine("WROND!");
    }
    
Console.WriteLine(question3);
userAnswer = Console.ReadLine();

if (userAnswer == answer3)
    {
        Console.WriteLine("correct");
        score ++;
    } 
else
    {
        Console.WriteLine("WROND!");
    }

Console.WriteLine($"Your score was {score}");