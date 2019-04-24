using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsProj.Pages
{
    public class BatCalcModel : PageModel
    {
        [BindProperty]
        //Tag Helpers
        public int GP { get; set; }

        public int RBI { get; set; }
        public int HR { get; set; }
        public int H { get; set; }
        public int NumAtBat { get; set; }
        public int SB { get; set; }

        public double OnBasePer { get; set; }
        public double OnBaseSlug { get; set; }
        public double WAR { get; set; }
        public decimal FieldPer { get; set; }

        public int Ab { get; set; }
        public double Avg { get; set; }
        public double Fpct { get; set; }
        public string Message { get; set; }

        public void OnPost()
        {
            GP = Convert.ToInt32(Request.Form[nameof(GP)]);
            Ab = Convert.ToInt32(Request.Form[nameof(Ab)]);
            H = Convert.ToInt32(Request.Form[nameof(H)]);
            HR = Convert.ToInt32(Request.Form[nameof(HR)]);
            RBI = Convert.ToInt32(Request.Form[nameof(RBI)]);
            SB = Convert.ToInt32(Request.Form[nameof(SB)]);
            Avg = Convert.ToDouble(Request.Form[nameof(Avg)]);
            OnBasePer = Convert.ToDouble(Request.Form[nameof(OnBasePer)]);
            OnBaseSlug = Convert.ToDouble(Request.Form[nameof(OnBaseSlug)]);
            WAR = Convert.ToDouble(Request.Form[nameof(WAR)]);
            Fpct = Convert.ToDouble(Request.Form[nameof(Fpct)]);
            int salary = GetSalaryforHitters(GP, Ab, H, HR, RBI, SB, Avg, OnBasePer, OnBaseSlug, WAR, Fpct);
            Message = "Salary: $" + salary;
        }
        public static int GetSalaryforHitters(int GP, int Ab, int H, int HR, int RBI, int SB,
             double Avg, double OnBasePer, double OnBaseSlug, double WAR, double Fpct)
        {
            int salary = (int)
            (
                    540000
                    + (GP * Math.Pow(10, 3))
                    + (Ab * Math.Pow(10, 2))
                    + (H * Math.Pow(10, 3))
                    + (HR * Math.Pow(10, 3))
                    + (RBI * Math.Pow(10, 3))
                    + (SB * Math.Pow(10, 2))
                    + (Avg * Math.Pow(10, 7))
                    + (OnBasePer * Math.Pow(10, 7))
                    + (OnBaseSlug * Math.Pow(10, 7))
                    + (WAR * Math.Pow(10, 6))
                    + (Fpct * Math.Pow(10, 5))
            );
            if (GP >= 100)
            {
                salary += 250000;
            }
            return salary;
        }
        public void OnGet()
        {
            Message = "Salary here.";

            //Contract.Ensures(Contract.Result<string>() != null);
            // Console.WriteLine("Enter amount of games played: ");

            //GP = Convert.ToInt32(Console.ReadLine());
            //GP = GP * 1000;
            /*
            //----------------------------------------------------
            //Console.WriteLine("Enter OnBase Percentage: ");
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
              */
        }
    }
}
