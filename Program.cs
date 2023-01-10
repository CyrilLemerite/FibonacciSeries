string ans = string.Empty;
do
{
    Console.Clear();
    Console.Beep();
    Console.WriteLine("______________________________________");
    Console.WriteLine("Program to compute Fibonacc's numbers");
    Console.WriteLine("______________________________________");
    Console.WriteLine();

    int a = 0, b = 1, c, i, numb;
    Console.Write("Enter the number of elements to compute: ");
    numb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.Write(a + " " + b + " ");
    for (i = 2; i < numb; ++i)
    {
        c = a + b;
        Console.Write(c + " ");

        a = b;
        b = c;
    }
    Console.WriteLine();
    Console.Beep();
    Console.WriteLine();
    Console.Write("Do you want to continue Yes(Y) or No(N)? ");
    ans = Console.ReadLine();
    Console.WriteLine();
    
} while (ans.ToLower() == "yes" || ans.ToLower() == "y");

Console.Beep();
Console.WriteLine("Thank you for using my app!");
Console.WriteLine();













