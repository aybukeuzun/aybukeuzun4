

Random rnd = new Random();
int cpuRandom = rnd.Next(1, 5);

bool loopActive = true; 

int numberofTries = 0;

while (loopActive)
{
    Console.WriteLine("Try to guess the cpu no:");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    if (userGuess == cpuRandom)
    {
        Console.WriteLine($"you won!");
        loopActive = false;
    }
}

Console.WriteLine("have a nice day!");
