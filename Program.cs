
string name = "Maciej";
char sex = 'm';
int age = 70;

if ( sex  == 'k' && age < 30 )
    {
        Console.WriteLine ("Kobieta poniżej 30 lat ");
    }
else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa ,lat 33 ");
    }
else if ( sex == 'm' && age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyżna o imieniu "+ name);
    }
else
    {
        Console.WriteLine("ktos inny, osoba o imieniu "+ name + " i wieku " +age);
    }