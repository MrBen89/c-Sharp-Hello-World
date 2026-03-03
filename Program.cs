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

// using System.Reflection.Metadata;

// string question1 = "What is the capital of the UK?";
// string answer1 = "London";
// string question2 = "What is 1 + 1?";
// string answer2 = "11";
// string question3 = "What is your favourite colour?";
// string answer3 = "green";
// int score = 0;

// Console.WriteLine(question1);
// string userAnswer = Console.ReadLine();

// if (userAnswer == answer1)
//     {
//         Console.WriteLine("correct");
//         score ++;
//     } 
// else
//     {
//         Console.WriteLine("WROND!");
//     }

// Console.WriteLine(question2);
// userAnswer = Console.ReadLine();

// if (userAnswer == answer2)
//     {
//         Console.WriteLine("correct");
//         score ++;
//     } 
// else
//     {
//         Console.WriteLine("WROND!");
//     }
    
// Console.WriteLine(question3);
// userAnswer = Console.ReadLine();

// if (userAnswer == answer3)
//     {
//         Console.WriteLine("correct");
//         score ++;
//     } 
// else
//     {
//         Console.WriteLine("WROND!");
//     }

// Console.WriteLine($"Your score was {score}");

//string.trim() -- Remove whitespace
//string.ToLower() 

//int++  <-- this will only return int, but willincrement after.
//++ int <-- will return the incremented int

//int.TryParse(inputstring, out int) <- will parse if possible

// Random random = new();
// int randomNum = random.Next(1,11); // returns less than 11

// Console.WriteLine("Enter the first number:");
//             int num1;
//             if (int.TryParse(Console.ReadLine(), out num1) == false)
//             {
//                 Console.WriteLine("Not a number, Fool!");
//             }
//             Console.WriteLine("Enter the second number:");
//             int num2;
//             if (int.TryParse(Console.ReadLine(), out num2) == false)
//             {
//                 Console.WriteLine("Not a number, Fool!");
//             }
//             Console.WriteLine("Choose an operation: +, -, *, /");
//             string operatorVal = Console.ReadLine();
//             switch (operatorVal)
//             {
//                 case "+":
//                 Console.WriteLine($"Result: {num1 + num2}");
//                 break;
//                 case "-":
//                 Console.WriteLine(num1 - num2);
//                 break;
//                 case "x":
//                 Console.WriteLine(num1 * num2);
//                 break;
//                 case "/":
//                 if (num2 != 0)
//                     Console.WriteLine(num1 / num2);
//                 else
//                     Console.WriteLine("Error: Division by zero is not allowed.");
//                 break;
//                 default:
//                 Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
//                 break;
//             }

for(int i=10;i>0;i--)
{
    //do some i stuff
    Console.WriteLine(i);
    Thread.Sleep(100);
}

//just like normal
int j = 10;
while(j > 0)
{
    Console.WriteLine(j);
    j--;
}