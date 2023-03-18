// Program, który polczy ile jakich cyfr występuje w podanej liczbie:
//
//Example"
//Dla liczby: 4566
//0 => 0
//1 => 0
//2 => 0
//3 => 0
//4 => 1
//5 => 1
//6 => 2
//7 => 0
//8 => 0
//9 => 0

string[] allDigits = new string[10];
int[] howMany = new int[allDigits.Length];

int number = 67866;
string numberInString = number.ToString();
char[] digitsInNumber = numberInString.ToArray();
//wypisanie tablicy cyfr 0-9
for (int i = 0; i < allDigits.Length; i++)
{
    allDigits[i] = i.ToString();
}

//
foreach (char characters in digitsInNumber)
{
    for (int i =0; i < allDigits.Length; i++)
    {
        if (i.ToString() == characters.ToString())
        {
            howMany[i]++;
        }
    }
    //Console.WriteLine(digit);
}

Console.WriteLine("Dla liczby: " + number);
for (int i = 0; i < allDigits.Length; i++)
{
    Console.WriteLine(allDigits[i] + " => " + howMany[i]);
}


