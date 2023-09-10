using System;

//ref link:https://www.youtube.com/watch?v=p9u6lk92JRU&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=48
//

class Cow
{
    static int blah = 20;
    //static int blah;
    static Cow()
    {
        //blah = 20;
        Console.WriteLine("static Cow()");
        throw new Exception();
    }
}

class MainClass
{
    static void Main()
    {
        try
        {
            new Cow();
        }
        catch { }
        new Cow();

    }
}