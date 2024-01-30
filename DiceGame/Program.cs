
int playerRandomNum = 0;
int enemRandomNum = 0;
int playerPoints = 0;
int enemPoints = 0;
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("press any key to roll the dice.");
    Console.ReadKey();
    playerRandomNum = random.Next(1, 7);
    Console.WriteLine("this roll of player!");
    Console.WriteLine($"Your roll is {playerRandomNum}");
    Console.ReadKey();
    Console.WriteLine("...");
    Thread.Sleep(1000);

    enemRandomNum = random.Next(1, 7);
    Console.WriteLine("this roll of enemy!");

    Console.WriteLine($"enemy roll is {enemRandomNum}");
    if (playerRandomNum > enemRandomNum)
    {
        playerPoints++;
        Console.WriteLine("player win this round .");
    }
    else if (enemRandomNum > playerRandomNum)
    {
        enemPoints++;
        Console.WriteLine("enemy win this round.");
    }
    else
    {
        Console.WriteLine("Drow!");
    }

    Console.WriteLine($"the score is now - player {playerPoints} . Enemy {enemPoints} .");
    Console.WriteLine();
}
if(playerPoints > enemPoints)
    Console.WriteLine("Congratulation, you win");
else if(playerPoints < enemPoints)
    Console.WriteLine("Sorry, you lose");
else Console.WriteLine("Drow!");
Console.ReadKey();