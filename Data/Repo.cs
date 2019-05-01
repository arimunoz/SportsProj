using System;
using System.Collections.Generic;
using Dapper;
using Microsoft.Extensions.Configuration;
using SportsProj.Models;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Configuration;

namespace SportsProj.Data
{
    public class Repo : CrudOps
    {
        IConfiguration _configuration;

        public Repo(IConfiguration configuration)
        {
            _configuration = configuration;
        }



         List<Batting> CrudOps.GetListBatting()
        {
            var connectionString = this.GetConnection();
            List<Batting> bats = new List<Batting>();

            using (var con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM batting";
                    bats = con.Query<Batting>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return bats;
            }
        }

        public string GetConnection()
        {
            var _MYSQLCONNECTION_ = _configuration.GetSection("ConnectionStrings_").GetSection("ContextString_").Value;
            return _MYSQLCONNECTION_;
        }
    }
}