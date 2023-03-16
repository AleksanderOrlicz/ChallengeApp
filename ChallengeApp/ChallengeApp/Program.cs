//-zadeklaruj zmienną z imieniem
//- zadeklaruj zmienną z płcią (dobierz zmienną
//-zadeklaruj zmienną z wiekiem
//=zadeklaruj dane i wyświetlasz
//jeden z komunikatów:
// (1) "Kobieta poniżej 30 lat"
// (2) "Ewa, lat 33"
// (3) "Niepełnoletni Mężczyzna"

string komunikat1 = "Kobieta poniżej 30 lat";
string komunikat2 = "Ewa, lat 33";
string komunikat3 = "Niepełnoletni Mężczyzna";


var name = "Jan";
bool czyKobieta = false;    // założenie istnienia dwóch płci ;)
string gender;
int age = 25;


if (czyKobieta == true && age < 30)
{
    Console.WriteLine(komunikat1);
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine(komunikat2);
}
else if (czyKobieta != true && age < 18)
{
    Console.WriteLine(komunikat3);
}
else
{
    if (czyKobieta == true)
    {
        gender = "Kobieta";
    }
    else
    {
        gender = "Mężczyzna";
    }
    Console.WriteLine(name + " " + gender + " " + age + " lat");
}
