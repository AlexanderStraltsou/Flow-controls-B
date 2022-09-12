/*See https://aka.ms/new-console-template for more information
Console.WriteLine("Type in a random number!");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in a random amount!");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < y; i++)
{
    Console.WriteLine("-------");
    Console.WriteLine();
    Console.WriteLine(x);
}
*/


//Welcome player to the game
//Decide monster and player health
//See who goes first
//Loop
//Attack
//Substract damage
//Change turn

int playerHealth;
int monsterHealth;
bool isPlayerTurn;
int minDamage = 1;
int maxDamage = 100;

WelcomePlayer();
DecidePlayerAndMonsterHealth();
DecideTurn();
Attack();
CalculateDamage();

void WelcomePlayer()

{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("WelcomePlayer to the epic monster battle game");
    Console.WriteLine("Winner of all ");
    Console.WriteLine("-------");


}

void DecidePlayerAndMonsterHealth()
{
    Console.WriteLine();
    Console.WriteLine("What should player HP be?");
    playerHealth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Great! What should monster HP be?");
    monsterHealth = Convert.ToInt32(Console.ReadLine());
    

}

void DecideTurn()
{
    int turn = new Random().Next(0, 2);
    if (turn == 0)
    {
        isPlayerTurn = true;
        Console.WriteLine();
        Console.WriteLine("Player goes first");
    }
    else
    {
        isPlayerTurn = false;
        Console.WriteLine();
        Console.WriteLine("Monster goes first");
    }
}

void Attack()
{
    if (isPlayerTurn)
    {
        Console.WriteLine();
        Console.WriteLine("Player Attacks!");
        monsterHealth -= CalculateDamage();
    }


    else
    {
        Console.WriteLine();
        Console.WriteLine("Monster Attacks!");
        playerHealth -= CalculateDamage();
    }
}

int CalculateDamage()
{
    int damage = new Random().Next(minDamage, maxDamage + 1);
    return damage;
}