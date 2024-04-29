using System;

class Program{
    public static string[] teams = [];
    public static int NoOfTeams = 0;
    public static void Main(string[] args)
    {
        Inputs();
        Console.WriteLine(NoOfTeams);

        Console.ReadKey();
    }

    public static void Inputs(){
        Console.Write("Enter list of teams(seprated by commas)");
        string? rawInput =   Console.ReadLine();
        teams = rawInput.Split(',');
        NoOfTeams = teams.Length;
    }
}
