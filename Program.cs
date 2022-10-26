//Valerie Aguilar
//October 24, 2022
// ---------Guess It------------//
//Peer Reviewed By:Amir S.
//Comment:No errors!


int level1;
int level2;
int level3;
int guessLevel1;
int guessLevel2;
int guessLevel3;
int guessNumber;
Random numGen = new Random();
string userDifficultyInput;
bool guessAgain = true;
bool playAgain = true;
string oneMoreTime;


//output lets play a game, and ask user to enter level of difficulty
Console.WriteLine("Let's play a game where you guess the number.");



//while loop so user has option to play again
while (playAgain == true)

{

Console.WriteLine("There are three levels, Easy, Medium, or Hard. Which level would you like to play?");
userDifficultyInput = Console.ReadLine().ToUpper();

    //if user inputs easy level, will ask user to input a number 1-10 and will generate a random number titled level1
    if (userDifficultyInput == "EASY")
    {

        Console.WriteLine("Guess a number 1 through 10");
        level1 = numGen.Next(1, 11);
        //initializing guess number and setting it to zero
        guessNumber = 0;
        //create a while loop where as long as guess again is equal to true, it will continue to go throught this loop
        while (guessAgain == true)
        {
            //this is having the guess numbers increase while guessAgaing is still true
            guessNumber++;

            //ask user to input guess and will convert to an integer
            guessLevel1 = Convert.ToInt32(Console.ReadLine());

            //create an if statement where if guessLevel1 is greater than the random number, will prompt user to guess again
            if (guessLevel1 > level1)
            {
                Console.WriteLine(guessLevel1 + " is too high. Guess again.");

            }


            //if guess is too low, will prompt user to guess again
            else if (guessLevel1 < level1)
            {
                Console.WriteLine(guessLevel1 + " is too low. Guess again.");
            }

            else
            {
                //if user input is equal to random number, will generate a statment saying the number guess was correct, and will display the number of guesses it took. Also setting guessAgain to false to exit the loop
                guessAgain = false;
                Console.WriteLine(guessLevel1 + " is the correct number! Congratulations it only took you " + guessNumber + " guesses.");
            }

        }


    }
//If user chooses medium, will ask user to input number 1 through 50, and random number will generate.
//will loop through until the correct number is guessed.
    else if (userDifficultyInput == "MEDIUM")
    {

        Console.WriteLine("Guess a number 1 through 50");
        level2 = numGen.Next(1, 51);

        guessNumber = 0;

        while (guessAgain == true)
        {
            guessNumber++;
            guessLevel2 = Convert.ToInt32(Console.ReadLine());
            if (guessLevel2 > level2)
            {
                Console.WriteLine(guessLevel2 + " is too high. Guess again.");

            }

            else if (guessLevel2 < level2)
            {
                Console.WriteLine(guessLevel2 + " is too low. Guess again.");
            }

            else
            {

                guessAgain = false;
                Console.WriteLine(guessLevel2 + " is the correct number! Congratulations it only took you " + guessNumber + " guesses.");


            }
        }

    }
   //If user chooses hard will ask user to input number 1 through 100, and random number will generate.
   //will loop through until the correct number is guessed.
    else if (userDifficultyInput == "HARD")
    {

        Console.WriteLine("Guess a number 1 through 100");
        level3 = numGen.Next(1, 101);

        guessNumber = 0;

        while (guessAgain == true)
        {
            guessNumber++;
            guessLevel3 = Convert.ToInt32(Console.ReadLine());
            if (guessLevel3 > level3)
            {
                Console.WriteLine(guessLevel3 + " is too high. Guess again.");

            }

            else if (guessLevel3 < level3)
            {
                Console.WriteLine(guessLevel3 + " is too low. Guess again.");
            }

            else
            {

                guessAgain = false;
                Console.WriteLine(guessLevel3 + " is the correct number! Congratulations it only took you " + guessNumber + " guesses.");




            }
        }


    } //If user enter anything other than easy, medium, or hard, will ask to enter a level
    else
    {
        Console.WriteLine("Please enter a level: Easy, Medium, or hard");
    }

//will ask user if they would like to play again, if yes, then will loop through, if not, will exit game. This is currently not working as it should. lol. I tried.
    Console.WriteLine("Would you like to play again? Type in 'Yes' or 'No'.");
    oneMoreTime = Console.ReadLine().ToUpper();
    if (oneMoreTime == "YES")
    {
        playAgain = true;  
        guessAgain = true;
        userDifficultyInput = "";

    }
    
    else
    {
        playAgain = false;
        Console.WriteLine("You have exited the game. Thank you for playing!");
    }

}