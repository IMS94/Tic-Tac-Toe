using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tik_tak_toe_pro
{
    
    public class DBManagement
    {

        
        public DBManagement() { 
            
        
        }

        public static void addSinglePlayerScores(String name, int score,int difficulty) {
            
            using (SqlConnection con = new SqlConnection(Tik_tak_toe_pro.Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    using (SqlCommand command = 
                        new SqlCommand("INSERT INTO singleplayer([user],[score],[difficulty]) VALUES(@user, @score,@difficulty)", con))
                    {
                        
                        command.Parameters.AddWithValue("@user",name);
                        command.Parameters.AddWithValue("@score",score);
                        command.Parameters.AddWithValue("@difficulty", difficulty);
                        con.Open();
                        Console.WriteLine(command.ExecuteNonQuery());
                        con.Close();
                        //Console.WriteLine(Tik_tak_toe_pro.Properties.Settings.Default.DataConnectionString);
                    }
                }
                catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    
                }
                
            }

        }





        public static void addMultiPlayerScores(String me,String opponent, String winner)
        {

            using (SqlConnection con = new SqlConnection(Tik_tak_toe_pro.Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    using (SqlCommand command =
                        new SqlCommand("INSERT INTO multiplayer([user1],[user2],[winner]) VALUES(@me, @opponent,@winner)", con))
                    {

                        command.Parameters.AddWithValue("@me", me);
                        command.Parameters.AddWithValue("@opponent", opponent);
                        command.Parameters.AddWithValue("@winner", winner);
                        con.Open();
                        Console.WriteLine(command.ExecuteNonQuery());
                        con.Close();
                        //Console.WriteLine(Tik_tak_toe_pro.Properties.Settings.Default.DataConnectionString);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);

                }

            }

        }



        /*
            Get the top ten in each difficulty.
         */

        public static NamesAndScores getSinglePlayerScores(int difficulty) {

            using (SqlConnection con = new SqlConnection(Tik_tak_toe_pro.Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    using (SqlCommand command =
 new SqlCommand(String.Format("SELECT TOP 10 * FROM [singleplayer] WHERE score>'0' and difficulty='{0}' ORDER BY [score] DESC",difficulty), con))
                    {
                        SqlDataReader reader;
                        con.Open();
                        reader = command.ExecuteReader();

                        NamesAndScores data = new NamesAndScores();

                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetName(0)+" "+
                                reader.GetString(1)+" "+reader.GetInt32(2).ToString()+" "+reader.GetInt32(3));
                            data.names.Add(reader.GetString(1));
                            data.scores.Add(reader.GetInt32(2));
                        }
                        con.Close();
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return null;
                }

            }

        }

    }
}
