using System;
class Program{
    public static string[] teams = [];
    public static int NoOfTeams = 0;
    public static int NoOfMatches = 0;
    public static void Main(string[] args)
    {
        Inputs();
        Console.WriteLine("No. of Teams = "  +NoOfTeams);
        Console.WriteLine("No. of BYE's = " + KnockoutTournament.NoOfByes());
        Console.WriteLine("No. of Matches = " + NoOfMatches);
        Console.WriteLine("No. of rounds = " + KnockoutTournament.NoOfRounds);
        Console.WriteLine("No. of Teams In Upper Half = " + KnockoutTournament.TeamsInUpper);
        Console.WriteLine("No. of Teams In Lower Half = " + KnockoutTournament.TeamsInLower);
        Console.WriteLine("No. of BYE's In Upper Half = " + KnockoutTournament.BYEsInUpper);
        Console.WriteLine("No. of BYE's In Lower Half = " + KnockoutTournament.BYEsInLower);
        KnockoutTournament.UpperHalfConstructor();
        KnockoutTournament.LowerHalfConstructor();
        foreach(string i in KnockoutTournament.isByeInUpper){
            Console.Write(i+" ");
        }
        Console.WriteLine("");
        foreach(string i in KnockoutTournament.isByeInLower){
            Console.Write(i+" ");
        }
        
        Console.ReadKey();
    }

    public static void Inputs(){
        Console.Write("Enter list of teams(seprated by commas) :-  ");
        string? rawInput =   Console.ReadLine();
        teams = rawInput.Split(',');
        NoOfTeams = teams.Length;
        NoOfMatches = teams.Length-1;
    }
}