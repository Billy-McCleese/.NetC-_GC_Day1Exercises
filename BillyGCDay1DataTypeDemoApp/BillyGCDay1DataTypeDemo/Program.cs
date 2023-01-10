
/*
// PascalCase
// camelCase

Console.WriteLine("Hello, World!");


// Variables: way to store data

// type VariableName = value;

/* int, double, bool, decimal
* int = integer value
* double = decimal that can be negative
* decimal = mainly used for money 
* bool = true/false

string greeting = "Good evening!"; //Text or number
int age = 0; //whole number not decimal
double height = -1.84; // use for all other decimal uses
decimal price = 1.84m; //use for money
bool IsAlive = true; //true/false
float xPosition = 45.455f;

double AverageGradeIncorrect = (99 + 80 + 70 + 24) / 4;  //Evaluated as a int since no values are decimal
double AverageGrade = (99.0 + 80.0 + 70.0 + 24.0) / 4.0; //Evaluated as a double dince values are decimal. Be Explicit
decimal AverageDecimal = (99.0m + 80 + 70 + 24) / 4;

//Expression is a 

Console.WriteLine(AverageGrade);
Console.WriteLine(AverageGradeIncorrect);
Console.WriteLine(AverageDecimal);

//CW tab x2 will create console.writeline from code snippet

//Null - lacking value
// int? means a nullable integer. Can do the same for all other types

int? CurrentAge = null;
double? TotalAge = null;
decimal? TotalAgeIncorrect = null;  
string MiddleName = null;

// Strings

string FirstName = "Dolly";
string LastName = "Parton";
Console.WriteLine(FirstName + " " + LastName); //string concatenation
Console.WriteLine($"{FirstName} Samantha {LastName}"); //String interpolation Curly braces here will provide space between 
string test = string.Format("{0} {1}", FirstName, LastName);
Console.WriteLine(test);


Console.WriteLine("123 Evergreen Terrace \nSpringfield, xx"); // escape characters \n gives a line break

Console.WriteLine(@"C:\Program\dahdahdah.txt"); // @ ignores escape characters

Console.Read(); // Pause the console. Continue on key press


Console.WriteLine("How old is your pet?");

string UserInput = Console.ReadLine();

int UserPetAge = int.Parse(UserInput);

Console.WriteLine(UserPetAge + 5);

*/

{
    Console.WriteLine("What's on your mind?");

    string UserThoughts = Console.ReadLine();

    Console.WriteLine(UserThoughts);
}


{
    Console.WriteLine("What's your favorite Number?");
    int FavNumber = int.Parse(Console.ReadLine());

    Console.WriteLine(FavNumber + 5);
}


{
    Console.WriteLine("What Number should we add .5 to?");
    double NumberToAdd = int.Parse(Console.ReadLine());

    Console.WriteLine(NumberToAdd + .5);
}

{
    Console.WriteLine("First number to add?");
    int FirstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Second number to add?");
    int SecondNumber = int.Parse(Console.ReadLine());

    int FinalNumber = (FirstNumber + SecondNumber);

    Console.WriteLine(FirstNumber + " plus " + SecondNumber + " Equals " + FinalNumber);
}

{
    Console.WriteLine("First number to multiply?");
    int FirstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Second number to multiply?");
    int SecondNumber = int.Parse(Console.ReadLine());

    int FinalNumber = (FirstNumber * SecondNumber);

    Console.WriteLine("Answer is " + FinalNumber);

    Console.WriteLine(FirstNumber + " Multiplied by " + SecondNumber + " Equals " + FinalNumber); 
}