
        Console.WriteLine("Choos counting system");
        Console.WriteLine("1 - Count 1-100");
        Console.WriteLine("2 - Only Even numbers to 50");
       
     
int Choice = int.Parse(Console.ReadLine());
if ( Choice == 1 )
{ 
    for (int Number = 1; Number <= 100; Number++)
    {

        Console.Write(Number + " ");
    }
    Console.WriteLine();
}
else if ( Choice == 2 )
{      int Even = 2;
    while (Even <= 50)
    {
        if (Even % 2 == 0)
        {
            Console.Write(Even + " ");
        }
        Even++;
    }
    }
        Console.ReadLine();
    
