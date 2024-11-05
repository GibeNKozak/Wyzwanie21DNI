int number = 456785740;
string numberToString = number.ToString();
int[] digits = new int[10];

foreach (char c in numberToString)
{
    int cyfra = int.Parse(c.ToString()); 
    digits[cyfra]++; 
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cyfra " + i + ": " + digits[i] + " razy");
}
