Console.Clear();

const double CAPPUCCINO = 3.50;
const double TEA = 1.50;
const double CACAO = 2.50;

Console.WriteLine("Please enter the amount of money that you fed into the machine: ");
double money = double.Parse(Console.ReadLine()!);

double product = 0;

do
{

    Console.Write("Which product would you like to buy? ");
    Console.WriteLine("1) Cappuccino (3.5), 2) Tea (1.5), 3) Cacao (2.5), 4) Nothing else: ");
    product = double.Parse(Console.ReadLine()!);

    switch (product)
    {
        case 1: money -= CAPPUCCINO; break;
        case 2: money -= TEA; break;
        case 3: money -= CACAO; break;

    }
    if (money < 1.50 && product == 1)
    {
        Console.WriteLine("Sorry, you do not have enough credit left ");
        money += CAPPUCCINO;
    }
    else if (money < 1.50 && product == 2)
    {
        Console.WriteLine("Sorry, you do not have enough credit left ");
        money += TEA;
    }
    else if (money < 1.50 && product == 3)
    {
        Console.WriteLine("Sorry, you do not have enough credit left ");
        money += CACAO;
    }

} while (product != 4);

Console.WriteLine("");
Console.Write($"You get {money} back.");

double money3 = Math.Floor(money / 2);
if (money3 < 0)
{
    Console.WriteLine($"You get 0 x 2 pieces.");
}
else
{
    Console.WriteLine($"You get {money3} x 2 pieces.");
}

double money4 = Math.Floor(money % 2 / 1);
if (money4 < 0)
{
    Console.WriteLine($"You get 0 x 1 pieces.");
}
else
{
    Console.WriteLine($"You get {money4} x 1 pieces.");
}

double money5 = Math.Floor(money % 2 % 1 / 0.5);
if (money5 < 0)
{
    Console.WriteLine($"You get 0 x 0.5 pieces.");
}
else
{
    Console.WriteLine($"You get {money5} x 0.5 pieces.");
}



















