// See https://aka.ms/new-console-template for more information

// Rock Paper Scissors Game
int playerOneScore = 0;
int playerTwoScore = 0;

Console.WriteLine($@"
____________________________________________________________

| Player One: {playerOneScore} | Player Two: {playerTwoScore} |
____________________________________________________________
");

Console.WriteLine(@"
What would you like to throw?
1) Rock
2) Paper 
3) Scissors
");

string userInput = Console.ReadLine();


// Rock Paper Scissors ASCII Art

// Rock  
 string Rock = (@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");

// Paper
string Paper = (@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");

// Scissors
string Scissors = (@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");


Dictionary<string, string> graphics = new Dictionary<string, string>()
{
    {"Rock", Rock }
};



List <string> options = new List<string> {"Rock","Paper","Scissors" };

Console.ReadLine();