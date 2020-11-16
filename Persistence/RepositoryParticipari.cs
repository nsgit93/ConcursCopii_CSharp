using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class RepositoryParticipari: IParticipariRepository
    {
        private string DBurl;

        public RepositoryParticipari(string url)
        {
            DBurl = url;
        }


        public void Delete(int id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "delete from Participari where ID=@id";
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Participare> FindAll()
        {
            List<Participare> participari = new List<Participare>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participari";

                        int size = cmd.ExecuteNonQuery();

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                participari.Add(new Participare(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetString(3)));
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return participari;
        }

        public Participare FindLastAdded()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participari\n" +
                                          "order by ID desc\n" +
                                          "limit 1";

                        int size = cmd.ExecuteNonQuery();

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return new Participare(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetString(3));
                        }
                    }



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Participare FindOne(int id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participari where ID=@id";
                        cmd.Parameters.AddWithValue("@id", id);

                        int size = cmd.ExecuteNonQuery();

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return new Participare(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetString(3));
                        }
                    }



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public int NrParticipariProba(string proba)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select count(*) as [SIZE] from Participari where Participari.Proba=@proba";
                        cmd.Parameters.AddWithValue("@proba", proba);

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return rdr.GetInt32(0);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public void Save(Participare entity)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var verifyCmd = new SQLiteCommand(connection))
                    {
                        verifyCmd.CommandText = "select count(*) as [SIZE] from Participari where Participari.Proba=@proba " +
                            "and Participari.IDparticipant=@id";
                        verifyCmd.Parameters.AddWithValue("@proba", entity.Proba);
                        verifyCmd.Parameters.AddWithValue("id", entity.IdParticipant);

                        verifyCmd.ExecuteNonQuery();

                        bool exists = false;

                        using (SQLiteDataReader rdr = verifyCmd.ExecuteReader())
                        {
                            rdr.Read();
                            exists = rdr.GetInt32(0) == 1;
                        }

                        if (exists)
                            throw new RepositoryException("Participantul cu ID-ul " + entity.IdParticipant +
                        " este deja inscris la proba <<" + entity.Proba + ">>");

                        using (var cmd = new SQLiteCommand(connection))
                        {
                            cmd.CommandText = "insert into Participari(IDparticipant,Proba,CategorieVarsta) values (@id,@proba,@categorie)";
                            cmd.Parameters.AddWithValue("@id", entity.IdParticipant);
                            cmd.Parameters.AddWithValue("proba", entity.Proba);
                            cmd.Parameters.AddWithValue("@categorie", entity.CategorieVarsta);

                            cmd.ExecuteNonQuery();


                        }
                    }
                    

                }

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int Size()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select count(*) as [SIZE] from Participari";

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return rdr.GetInt32(0);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }       

        public void Update(Participare entity)
        {

            throw new NotImplementedException();

        }


    }
}
