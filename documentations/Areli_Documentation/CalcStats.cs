using System;
namespace CalcStats
{
    class Calculator{
        static void Main()
        {
            Scanner scanner = new Scanner(java.lang.System.@in);
            //Variables
            int gp, RBI, HR, H, numBat, SB;
            double OnBasePer, OnBaseSlug, WAR, fieldPer;

            Console.WriteLine("Enter amount of games played: ");
            gp = Convert.ToInt32(Console.ReadLine());
            //gp = gp * 1000;
            Console.WriteLine("Games Played: {0}", gp);
            ///////////////////////////////////////
            //TEST Program in C#

            //Contract.Ensures(Contract.Result<string>() != null);
             Console.WriteLine("Enter amount of games played: ");

            GP = Convert.ToInt32(Console.ReadLine());
            GP = GP * 1000;
            
            //----------------------------------------------------
            Console.WriteLine("Enter OnBase Percentage: ");
            OnBasePer = Convert.ToDecimal(Console.ReadLine());
            OnBasePer = OnBasePer * 1000000;
            //----------------------------------------------------
            //Console.WriteLine("Enter OnBase Slugging: ");
            OnBaseSlug = Convert.ToDecimal(Console.ReadLine());
            OnBaseSlug = OnBaseSlug * 1000000;
            //----------------------------------------------------
            // Console.WriteLine("Enter RBI: ");
            RBI = Convert.ToInt32(Console.ReadLine());
            RBI = RBI * 10000;
            //----------------------------------------------------
            // Console.WriteLine("Enter Home Run: ");
            HR = Convert.ToInt32(Console.ReadLine());
            HR = HR * 10000;
            //----------------------------------------------------
            // Console.WriteLine("Enter Hits: ");
            H = Convert.ToInt32(Console.ReadLine());
            H = H * 10000;
            //----------------------------------------------------
            //Console.WriteLine("Enter WAR: ");
            WAR = Convert.ToDecimal(Console.ReadLine());
            WAR = WAR * 100000;
            //----------------------------------------------------
            // Console.WriteLine("Enter number at Bat: ");
            numAtBat = Convert.ToInt32(Console.ReadLine());
            numAtBat = numAtBat * 100;
            //----------------------------------------------------
            //Console.WriteLine("Enter fielding percentage: ");
            fieldPer = Convert.ToDecimal(Console.ReadLine());
            fieldPer = fieldPer * 10000;
            //----------------------------------------------------
            // Console.WriteLine("Enter stolen bases: ");
            SB = Convert.ToInt32(Console.ReadLine());
            SB = SB * 100;
            //----------------------------------------------------
            Console.WriteLine("Games Played: {0}$", GP);
            Console.WriteLine("OnBase Percentage: {0}$", OnBasePer);
            Console.WriteLine("OnBase Slugging: {0} $", OnBaseSlug);
            Console.WriteLine("RBI:  {0}$", RBI);
            Console.WriteLine("Home Run: {0}$", HR);
            Console.WriteLine("Hits: {0}$", H);
            Console.WriteLine("WAR:  {0}$", WAR);
            Console.WriteLine("Number at Bat:  {0}$", numAtBat);
            Console.WriteLine("Fielding percentage: {0}$", fieldPer);
            Console.WriteLine("Stolen bases:  {0}$", SB);
            
        }
    }
}