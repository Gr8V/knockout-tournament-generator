using System;
class KnockoutTournament{
    public static int NoOfRounds = 0;
    public static int TeamsInUpper = (Program.NoOfTeams+1)/2;
    public static int TeamsInLower = (Program.NoOfTeams-1)/2;
    public static int BYEsInUpper = (NoOfByes()-1)/2;
    public static int BYEsInLower = (NoOfByes()+1)/2;
    public static string[] UpperHalf = [];
    public static string[] LowerHalf = [];
    public static List<string> isByeInUpper = [];
    public static List<string> isByeInLower = [];
    public static List<string> Byes = isByeInUpper.Concat(isByeInLower).ToList();
    public static int NoOfByes(){
        int powerOfTwo = 1;
        while (powerOfTwo < Program.NoOfTeams)
        {
            powerOfTwo *= 2;
        }
        int byes = powerOfTwo - Program.NoOfTeams;
        return byes;
    }

    public static void UpperHalfConstructor(){
        int startIndex = 0;
        int endIndex = TeamsInUpper;
        UpperHalf = new string[endIndex-startIndex];
        Array.Copy(Program.teams, startIndex, UpperHalf, 0, endIndex-startIndex);
        foreach(string i in UpperHalf){
            isByeInUpper.Add("no");
        }
        int frontPointer = 0;
        int backPointer = -1;
        for (int i = 0; i < BYEsInUpper; i++)
        {
            if(i%2 == 0){
                isByeInUpper[frontPointer] = "yes";
                frontPointer++;
            }
            else if (i%2 == 1)
            {
                isByeInUpper[isByeInUpper.ToArray().Length+backPointer] = "yes";
                backPointer--;
            }
        }
        foreach(string j in UpperHalf){
            Console.Write(j+" ");
        }
        Console.WriteLine("");
    }
    public static void LowerHalfConstructor(){
        int startIndex = TeamsInUpper;
        int endIndex = Program.teams.Length;
        LowerHalf = new string[endIndex-startIndex];
        Array.Copy(Program.teams, startIndex, LowerHalf, 0, endIndex-startIndex);
        foreach(string i in LowerHalf){
            isByeInLower.Add("no");
        }
        int frontPointer = 0;
        int backPointer = -1;
        for (int i = 0; i < BYEsInLower; i++)
        {
            if (i%2 == 0)
            {
                isByeInLower[isByeInLower.ToArray().Length+backPointer] = "yes";
                backPointer--;
            }
            else if(i%2 == 1){
                isByeInLower[frontPointer] = "yes";
                frontPointer++;
            }
        }
        foreach(string j in LowerHalf){
            Console.Write(j+" ");
        }
        Console.WriteLine("");
    }  
}