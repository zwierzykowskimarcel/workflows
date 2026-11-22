Console.WriteLine("Podaj punkty życia");
int healthPoitns = int.Parse(Console.ReadLine());

Console.WriteLine("Podstawowe obrazenia broni");
int baseAttackDamage = int.Parse(Console.ReadLine());

Console.WriteLine("Czy posiadasz miksture?");
bool hasPotion = bool.Parse(Console.ReadLine());

Console.WriteLine("Wybierz akcje: 1. Atak, 2. leczenie 3.Ucieczka");
Console.WriteLine("1. Atak");
Console.WriteLine("2. Leczenie");
Console.WriteLine("3. Ucieczka");
int option = int.Parse(Console.ReadLine());

if (healthPoitns <= 0)
{
    Console.WriteLine("Przegrana");
}
else
{
    switch (option)
    {
        case 1: 
            Console.WriteLine(baseAttackDamage);
            break;
        case 2:
            if (hasPotion)
            {
                Console.WriteLine("Możesz sie uleczyć");
            }
            Console.WriteLine(healthPoitns);
            break;
        case 3:
            Console.WriteLine("Ucieczka");
            break;
        default:
            Console.WriteLine("Nieznana akcja");
            break;
    }

    if (healthPoitns < 20)
    {
        Console.WriteLine("Niski stan zdrowia");
    }
}


