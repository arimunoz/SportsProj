using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsProj.Models;

namespace SportsProj.Data
{
    public class DbInitializer
    {
        public static void Initialize(AthleteStatsContext context)
        {
            if (context.Player.Any())
            {
                return;
            }

            var players = new Player[]
            {
            new Player{FirstName="Cody",LastName="Bellinger",Team="Los Angeles Dodgers"},
            new Player{FirstName="Tim",LastName="Anderson",Team="Chicago White Sox"},
            new Player{FirstName="Carlos",LastName="Santana",Team="Cleveland Indians"},
            new Player{FirstName="Anthony",LastName="Rendon",Team="Washington Nationals"},
            new Player{FirstName="Jeff",LastName="McNeil",Team="New York Mets"},
            new Player{FirstName="Elvis",LastName="Andrus",Team="Texas Rangers"},
            new Player{FirstName="Jorge",LastName="Polanco",Team="Minnesota"},
            new Player{FirstName="Christian",LastName="Walker",Team="Arizona Diamondbacks"},
            new Player{FirstName="Austin",LastName="Meadows",Team="Tampa Bay Rays"},
            new Player{FirstName="Jason",LastName="Heyward",Team="Chicago Cubs"},
            new Player{FirstName="J.D.",LastName="Martinez",Team="Boston Red Soxs"},
            new Player{FirstName="Trey",LastName="Mancini",Team="Baltimore Orioles"},
            new Player{FirstName="Clint",LastName="Frazier",Team="New York Yankees"},
            new Player{FirstName="Yasmani",LastName="Grandal",Team="Milwaukee Brewers"},
            new Player{FirstName="Nick",LastName="Markakis",Team="Atlanta Braves"},
            new Player{FirstName="David",LastName="Peralta",Team="Arizona Diamondbacks"},
            new Player{FirstName="Mike",LastName="Trout",Team="Los Angeles Angels"},
            new Player{FirstName="Jean",LastName="Segura",Team="Philadelphia"},
            new Player{FirstName="Paul",LastName="DeJong",Team="St. Louis Cardinals"},
            new Player{FirstName="Pete",LastName="Alonso",Team="New York Mets"},
            new Player{FirstName="Marcus",LastName="Semien",Team="Oakland Athletics"},
            new Player{FirstName="Willson",LastName="Contreras",Team="Chicago Cubs"},
            new Player{FirstName="Shin-Soo",LastName="Choo",Team="Texas Rangers"},
            new Player{FirstName="Hunter",LastName="Dozier",Team="Kansas City Royals"},
            new Player{FirstName="Freddie",LastName="Freeman",Team="Atlanta Braves"},
            new Player{FirstName="Nelson",LastName="Cruz",Team="Minnesota Brewers"},
            new Player{FirstName="Freddy",LastName="Galvis",Team="Toronto Blue Jays"},
            new Player{FirstName="Alex",LastName="Bregman",Team="Houston Astros"},
            new Player{FirstName="Adam",LastName="Eaton",Team="Washington Nationals"},
            new Player{FirstName="Dexter",LastName="Fowler",Team="St. Louis Cardinals"},
            new Player{FirstName="Justin",LastName="Smoak",Team="Toronto Blue Jays"},
            new Player{FirstName="Wil",LastName="Myers",Team="San Diego Padres"},
            new Player{FirstName="Ben",LastName="Zobrist",Team="Chicago Cubs"},
            new Player{FirstName="Corey",LastName="Dickerson",Team="Pitsburgh Pirates"},
            new Player{FirstName="Javier",LastName="Baez",Team="Chicago Cubs"},
            };
            foreach (Player p in players)
            {
                context.Player.Add(p);
            }
            context.SaveChanges();

            var teams = new Teams[]
            {
                new Teams{TeamsID=100, PlayerID=1, StatID=1010, StatValues=StatValues.A},
                new Teams{TeamsID=102, PlayerID=2, StatID=1012, StatValues=StatValues.B},
                new Teams{TeamsID=103, PlayerID=3, StatID=1013, StatValues=StatValues.D},
                new Teams{TeamsID=104, PlayerID=4, StatID=1010, StatValues=StatValues.A},
                new Teams{TeamsID=105, PlayerID=5, StatID=1012, StatValues=StatValues.B},
                new Teams{TeamsID=106, PlayerID=6, StatID=1013},
                new Teams{TeamsID=100, PlayerID=7, StatID=1015, StatValues=StatValues.A},
                new Teams{TeamsID=102, PlayerID=8, StatID=1014, StatValues=StatValues.B},
                new Teams{TeamsID=103, PlayerID=9, StatID=1016, StatValues=StatValues.F},
                new Teams{TeamsID=107, PlayerID=10, StatID=1013, StatValues=StatValues.A},
                new Teams{TeamsID=108, PlayerID=11, StatID=1015},
                new Teams{TeamsID=109, PlayerID=12, StatID=1013, StatValues=StatValues.F},
                new Teams{TeamsID=105, PlayerID=13, StatID=2024, StatValues=StatValues.B},
                new Teams{TeamsID=103, PlayerID=14, StatID=2022, StatValues=StatValues.C},
                new Teams{TeamsID=1011, PlayerID=15, StatID=1013, StatValues=StatValues.A},
                new Teams{TeamsID=1010, PlayerID=16, StatID=1018},
                new Teams{TeamsID=109, PlayerID=117, StatID=1021, StatValues=StatValues.F},
            };
            foreach (Teams t in teams)
            {
                context.Teams.Add(t);
            }
            context.SaveChanges();

            var stat = new Stat[]
            {
            new Stat{StatID=1010,statName="GP",},
            new Stat{StatID=1012,statName="AB"},
            new Stat{StatID=1013,statName="H"},
            new Stat{StatID=1014,statName="HR"},
            new Stat{StatID=1015,statName="OPS"},
            new Stat{StatID=1016,statName="OBP"},
            new Stat{StatID=1017,statName="R"},
            new Stat{StatID=1018,statName="WAR"},
            new Stat{StatID=1019,statName="FPCT"},
            new Stat{StatID=1020,statName="RBI"},
            new Stat{StatID=1021,statName="SB"},
            new Stat{StatID=2022,statName="IP"},
            new Stat{StatID=2023,statName="SO"},
            new Stat{StatID=2024,statName="W"},
            new Stat{StatID=2025,statName="ERA"}
            };
            foreach (Stat s in stat)
            {
                context.Stat.Add(s);
            }
            context.SaveChanges();

        }
    }

}
