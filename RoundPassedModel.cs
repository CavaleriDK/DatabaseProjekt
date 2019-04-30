using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DatabaseProjekt
{
    class RoundPassedModel
    {
        static string tableName = "RoundPassed";
        static string extraTableName = "RoundPassedUnitType";
        string RoundPassedQuery = "CREATE TABLE IF NOT EXISTS " + tableName + "(id integer primary key, campingplads_income integer, campingplads_id integer, round_number integer)";
        string RoundPassedUnitTypeQuery = "CREATE TABLE IF NOT EXISTS " + extraTableName + "(id integer primary key, round_passed_id integer, unit_type_id integer)";


        //private static RoundPassedModel instance;

        //public static RoundPassedModel Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new RoundPassedModel();
        //        }
        //        return instance;
        //    }
        //}

        public RoundPassedModel(int id, int income, int campingplads_id, int round_number)
        {
            

            //GameWorld.Connection.
        }


        public void CreateDatabaseStructure()
        {
            SQLiteCommand cmd = GameWorld.Connection.CreateCommand();
            cmd.CommandText = RoundPassedQuery;
            cmd.ExecuteNonQuery();

            cmd.CommandText = RoundPassedUnitTypeQuery;
            cmd.ExecuteNonQuery();
        }

        public static List<RoundPassedModel> GetRoundsByNumber(int roundNumber)
        {
            List<RoundPassedModel> returnList = new List<RoundPassedModel>();
            
            string query = "SELECT * FROM " + tableName + " WHERE round_number=" + roundNumber;

            SQLiteCommand cmd = GameWorld.Connection.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                returnList.Add(new RoundPassedModel(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
            }

            return returnList;
        }
    }
}
