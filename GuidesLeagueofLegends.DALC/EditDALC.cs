using GuidesLeagueofLegends.BE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidesLeagueofLegends.DALC
{
    public class EditDALC
    {    
        public void AddGuides(Guides guides)
        {
            string Connect;
            Connect = "Database=" + "guides_league_of_legends" + ";Server=" + "localhost" + ";User=" + "root" + ";Password=" + "; CharSet=utf8";

            using (MySqlConnection mysql_db = new MySqlConnection(Connect))
            {
                mysql_db.Open();

                MySqlDataReader QueryResult;

                MySqlCommand MySqlQuery = mysql_db.CreateCommand();

                MySqlQuery.CommandText = "INSERT INTO `guides` (HERO_ID,NAME,DESCRIPTION) VALUES ('" + guides.HeroID + "','" + guides.Name + "','" + guides.Description + "') ";

                QueryResult = MySqlQuery.ExecuteReader();

                //Закрываем соеденинение 
                QueryResult.Close();
                mysql_db.Close();
            }
        }


        public List<Persons> GetPersons()
        {
            string Connect;
            Connect = "Database=" + "guides_league_of_legends" + ";Server=" + "localhost" + ";User=" + "root" + ";Password=" + "; CharSet=utf8";

            List<Persons> list = new List<Persons>();

            using (MySqlConnection mysql_db = new MySqlConnection(Connect))
            {
                mysql_db.Open();

                MySqlDataReader QueryResult;

                MySqlCommand MySqlQuery = mysql_db.CreateCommand();

                MySqlQuery.CommandText = "SELECT * FROM `list_hero`";

                QueryResult = MySqlQuery.ExecuteReader();

                while (QueryResult.Read())
                {
                    Persons persons = new Persons();
                    persons.ID = Convert.ToInt32(QueryResult["ID"]);
                    persons.NameHero = QueryResult["NAME"].ToString();
                    persons.Description = QueryResult["DESCRIPTIONS"].ToString();
                    list.Add(persons);
                }

                //Закрываем соеденинение 
                QueryResult.Close();
                mysql_db.Close();
            }
            return list;
        }

        public List<Guides> GetGuides()
        {
            string Connect;
            Connect = "Database=" + "guides_league_of_legends" + ";Server=" + "localhost" + ";User=" + "root" + ";Password=" + "; CharSet=utf8";

            List<Guides> list = new List<Guides>();

            using (MySqlConnection mysql_db = new MySqlConnection(Connect))
            {
                mysql_db.Open();

                MySqlDataReader QueryResult;

                MySqlCommand MySqlQuery = mysql_db.CreateCommand();

                MySqlQuery.CommandText = "SELECT * FROM `guides`";

                QueryResult = MySqlQuery.ExecuteReader();

                while (QueryResult.Read())
                {
                    Guides guides = new Guides();

                    guides.ID = (int)QueryResult["ID"];
                    guides.HeroID = (int)QueryResult["HERO_ID"];
                    guides.Name = QueryResult["NAME"].ToString();
                    guides.Description = QueryResult["DESCRIPTION"].ToString();

                    list.Add(guides);
                }

                //Закрываем соеденинение 
                QueryResult.Close();
                mysql_db.Close();
            }
            return list;
        }

        public List<Guides> GetGuides(int heroID)
        {
            string Connect;
            Connect = "Database=" + "guides_league_of_legends" + ";Server=" + "localhost" + ";User=" + "root" + ";Password=" + "; CharSet=utf8";

            List<Guides> list = new List<Guides>();

            using (MySqlConnection mysql_db = new MySqlConnection(Connect))
            {
                mysql_db.Open();

                MySqlDataReader QueryResult;

                MySqlCommand MySqlQuery = mysql_db.CreateCommand();

                MySqlQuery.CommandText = "SELECT * FROM `guides` WHERE HERO_ID = '" + heroID + "'";

                QueryResult = MySqlQuery.ExecuteReader();

                while (QueryResult.Read())
                {
                    Guides guides = new Guides();

                    guides.ID = (int)QueryResult["ID"];
                    guides.HeroID = (int)QueryResult["HERO_ID"];
                    guides.Name = QueryResult["NAME"].ToString();
                    guides.Description = QueryResult["DESCRIPTION"].ToString();

                    list.Add(guides);
                }

                //Закрываем соеденинение 
                QueryResult.Close();
                mysql_db.Close();
            }
            return list;
        }

        public void AddPerson(Persons persons)
        {
            string Connect;
            Connect = "Database=" + "guides_league_of_legends" + ";Server=" + "localhost" + ";User=" + "root" + ";Password=" + "; CharSet=utf8";

            using (MySqlConnection mysql_db = new MySqlConnection(Connect))
            {
                mysql_db.Open();

                MySqlDataReader QueryResult;

                MySqlCommand MySqlQuery = mysql_db.CreateCommand();

                MySqlQuery.CommandText = "INSERT INTO `list_hero` (NAME,DESCRIPTIONS) VALUES ('" + persons.NameHero + "','" + persons.Description + "') ";

                QueryResult = MySqlQuery.ExecuteReader();
                
                //Закрываем соеденинение 
                QueryResult.Close();
                mysql_db.Close();
            }
        }

    }
}
