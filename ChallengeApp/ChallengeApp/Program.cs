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

int[] allDigits = new int[10];
int[] howMany = new int[allDigits.Length];

int number = 4566;
string numberInString = number.ToString();
char[] digitsInNumber = numberInString.ToArray();
//wypisanie tablicy cyfr 0-9
for (int i = 0; i < allDigits.Length; i++)
{
    allDigits[i] = i;
}

//
foreach (char characters in digitsInNumber)
{
    foreach (int digit in allDigits)
    {
        if (digit == characters)
        {
            howMany[digit]++;
        }
    }
    //Console.WriteLine(digit);
}

Console.WriteLine("Dla liczby: " + number);
foreach (int digit in allDigits)
{
    Console.WriteLine(allDigits[digit] + " => " + howMany[digit]);
}


