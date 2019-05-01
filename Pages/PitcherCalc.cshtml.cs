using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsProj.Pages
{
    [Authorize]
    public class PitcherCalcModel : PageModel
    {
        [BindProperty]
        //Tag Helpers
        public int GP { get; set; }

        public int IP { get; set; }
        public int SO { get; set; }
        public int W { get; set; }


        public double WAR { get; set; }
        public double WPCT { get; set; }
        public double FPCT { get; set; }
        public double ERA { get; set; }
       

        public string Message { get; set; }

        public void OnPost()
        {
            GP = Convert.ToInt32(Request.Form[nameof(GP)]);
            IP = Convert.ToInt32(Request.Form[nameof(IP)]);
            SO = Convert.ToInt32(Request.Form[nameof(SO)]);
            W = Convert.ToInt32(Request.Form[nameof(W)]);

            WAR = Convert.ToDouble(Request.Form[nameof(WAR)]);
            WPCT = Convert.ToDouble(Request.Form[nameof(WPCT)]);
            FPCT = Convert.ToDouble(Request.Form[nameof(FPCT)]);

            ERA = Convert.ToDouble(Request.Form[nameof(ERA)]);


            int salary = GetSalaryforPitchers(GP, IP, SO, W, WAR, WPCT, FPCT, ERA);
            Message = "Salary: $" + salary;
        }
        public int GetSalaryforPitchers(int GP, int IP, int SO, int W, double WAR, double WPCT, double FPCT, double ERA)
        {
            int salary = (int)
            (
                    540000
                    + (GP * Math.Pow(10, 3))
                    + (IP * Math.Pow(10, 3))
                    + (SO * Math.Pow(10, 3))
                    + (W * Math.Pow(10, 4))
                    + (WAR * Math.Pow(10,6))
                    + (WPCT * Math.Pow(10, 5))
                    + (FPCT * Math.Pow(10, 3))
                    + (ERA * Math.Pow(10, 5.7))

            );


            if (ERA >= 0)
            {
                salary += salary + 10000000;
            } else if(ERA <= 2)
            {
                salary += salary + 10000000;
            }
            else if (ERA >= 2)
            {
                salary += salary + 1000000;
            }
            else if (ERA <= 3)
            {
                salary += salary + 1000000;
            }
            else if (ERA >= 3)
            {
                salary += salary + 1000000;
            }
            else if (ERA <= 4)
            {
                salary += salary + 1000000;
            }

            else if (ERA >= 4)
            {
                salary += salary + 100000;
            }
            else if (ERA <= 5)
            {
                salary += salary + 100000;
            }
            else if (ERA >= 5)
            {
                salary += salary + 10000;
            }
            return salary;
        }
        public void OnGet()
        {
            Message = "Salary here.";
        }
    }
}
