Console.WriteLine("Podaj imię");
var name = Console.ReadLine();

bool isActive = false;
var wiek = 0;
var age = 0;

while (isActive == false)
{
    Console.WriteLine("Podaj wiek: ");
    wiek = int.Parse(Console.ReadLine());
    age = wiek;
    isActive = true;
}



Console.WriteLine("Podaj płeć (k - kobieta, m- mężczyzna");
var sex = Console.ReadLine();
if (sex == "k")
{
    sex = "Kobieta";
}
else
{
    sex = "Mężczyzna";
}

Console.WriteLine("Twoje dane to: Imię: " + name + " Wiek: " + age + " Płeć: " + sex + "");
Console.WriteLine("");

if (sex == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}

else if (sex == "Mężczyzna")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }

    else if (age == 41 && name == "Marek")
    {
        Console.WriteLine("Marek, który ma 41 lat");
    }

    else
    {
        Console.WriteLine("Pełnoletni mężczyzna o imieniu " + name + "");
    }
}
