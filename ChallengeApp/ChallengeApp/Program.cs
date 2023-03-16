//-zadeklaruj zmienną z imieniem
//- zadeklaruj zmienną z płcią (dobierz zmienną
//-zadeklaruj zmienną z wiekiem
//=zadeklaruj dane i wyświetlasz
//jeden z komunikatów:
// (1) "Kobieta poniżej 30 lat"
// (2) "Ewa, lat 33"
// (3) "Niepełnoletni Mężczyzna"

string comment1 = "Kobieta poniżej 30 lat";
string comment2 = "Ewa, lat 33";
string comment3 = "Niepełnoletni Mężczyzna";


var name = "Anna";
bool ifWoman = true;    // założenie istnienia dwóch płci ;)
string gender;
int age = 35;


if (ifWoman == true && age < 30)
{
    Console.WriteLine(comment1);
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine(comment2);
}
else if (ifWoman != true && age < 18)
{
    Console.WriteLine(comment3);
}
else
{
    if (ifWoman == true)
    {
        gender = "Kobieta";
    }
    else
    {
        gender = "Mężczyzna";
    }
    Console.WriteLine(name + " " + gender + " " + age + " lat");
}
