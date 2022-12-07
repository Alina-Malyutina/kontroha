Console.WriteLine("This program assepts size of array and strings for it.");
Console.WriteLine("After that program print only such lines there quantity of symbols less than or equal to 3");
Console.Write("Enter quantity of strings, that you going to enter: ");
int N = Convert.ToInt32(Console.ReadLine());
string [] ArrayStart = new string [N];

for (int i = 0; i < ArrayStart.Length; i++)
{
    Console.Write("Enter string: ");
    ArrayStart[i] = Console.ReadLine()!;
}

string [] ArrayFinal = new string [N];
int temp = 0;

for (int i = 0; i < ArrayStart.Length; i++)
{
    if (ArrayStart[i].Length <= 3)
    {
        ArrayFinal[temp] = ArrayStart[i];
        temp++;
    }
}

Console.Write("[");
for (int i = 0; i < ArrayFinal.Length; i++)
{
    if (ArrayFinal[i] is not "")
    {
        Console.Write($"{ArrayFinal[i]} ,");
    }
}

Console.Write("]");