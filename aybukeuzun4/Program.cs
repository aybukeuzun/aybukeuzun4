

Random rnd = new Random();

int myRandom;

for (int i = 0; i < 8; i++)
{
    myRandom = rnd.Next(1, 21);
    Console.WriteLine($"{i + 1}. {myRandom}");
}






//for (int i = 0; i < 10; i++) // i++ ==> i + 1
//{
//    Console.WriteLine($"{i + 1}. I will not skip Zoom classes.");
//}

