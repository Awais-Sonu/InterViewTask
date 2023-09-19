// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

// Uncomment BelowLine for Task 1

//********** CODE FOR TASK 1 Starts ***************//

var value = "13344";
Console.WriteLine($"Team of {value} = " + TeamStatus.GetTeam(value));

//********** CODE FOR TASK 1 Ends ***************//

// UNCOMMENT BELOW LINE FOR TASK 2

//********** CODE FOR TASK 2 Starts ***************//

var unsantaizedValue = "xyz23n23n3";
Console.WriteLine($"Team of {unsantaizedValue.SanatizeString()} = " + TeamStatus.GetTeam(unsantaizedValue.SanatizeString()));

//********** CODE FOR TASK 2 Ends ***************//

//UNCOMMENT BELOWLINE FOR TASK 3

//********** CODE FOR TASK 2 Starts ***************//

var math = new MathExtention();
string wordedMathSentence = "one minus two";
try
{
    var result = math.WordedMath(wordedMathSentence);
    Console.WriteLine($"Result Of {wordedMathSentence} = " + result);
}
catch (Exception ex)
{

    throw ex;
}

//********** CODE FOR TASK 2 Ends ***************//