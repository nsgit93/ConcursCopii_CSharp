using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using Domain;

namespace Persistence
{
    public class RepositoryParticipanti : IParticipantiRepository

    {
        private string DBurl;

        private static readonly ILog logger = LogManager.GetLogger(typeof(RepositoryParticipanti));

        public RepositoryParticipanti(string url, string log4netconfig)
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo(log4netconfig));
            logger.Info("Initializing RepositoryJdbcParticipanti with DB URI: "  + url);
            DBurl = url;
        }


        public void Delete(int id)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.Delete("+id+")");
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "delete from Participanti where ID=@id";
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.Delete(" + id + ")");
        }

        public List<Participant> FindAll()
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.FindAll()");
            List<Participant> participanti = new List<Participant>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participanti";

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader()) 
                        {
                            while (rdr.Read())
                            {
                                participanti.Add(new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3)));
                            }
                        }                            
                    }                       

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.FindAll()");
            return participanti;
        }

        public Participant FindOne(int id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participanti where ID=@id";
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3));
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

        public List<Participant> FindParticipantiByProba(string proba)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.FindParticipantiByProba("+proba+")");
            List<Participant> participanti = new List<Participant>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select p.ID,p.Nume,p.Varsta,p.NumarParticipari from Participanti p " +
                                          "inner join Participari on " +
                                          "p.ID = Participari.IDparticipant " +
                                          "where Participari.Proba = @proba " +
                                          "group by p.ID";

                        cmd.Parameters.AddWithValue("@proba", proba);

                        int size = cmd.ExecuteNonQuery();

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                participanti.Add(new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3)));
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.FindParticipantiByProba(" + proba + ")");
            return participanti;
        }

        
        public List<Participant> FindParticipantiByVarsta(string categorieVarsta)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.FindParticipantiByVarsta(" + categorieVarsta + ")");
            List<Participant> participanti = new List<Participant>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();

                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select p.ID,p.Nume,p.Varsta,p.NumarParticipari from Participanti p " +
                                          "inner join Participari on " +
                                          "p.ID = Participari.IDparticipant " +
                                          "where Participari.CategorieVarsta = @varsta " +
                                          "group by p.ID";

                        cmd.Parameters.AddWithValue("@varsta", categorieVarsta);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {

                            while (rdr.Read())
                            {
                                participanti.Add(new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3)));
                            }
                            
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.FindParticipantiByVarsta(" + categorieVarsta + ")");
            return participanti;
        }


        public List<Participant> FindParticipantiByProba_Varsta(string proba, string categorieVarsta)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.FindParticipantiByProba_Varsta(" + proba+", "+categorieVarsta + ")");
            List<Participant> participanti = new List<Participant>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select p.ID,p.Nume,p.Varsta,p.NumarParticipari from Participanti p " +
                                          "inner join Participari on " +
                                          "p.ID = Participari.IDparticipant " +
                                          "where Participari.CategorieVarsta = @varsta and Participari.Proba = @proba " +
                                          "group by p.ID";

                        cmd.Parameters.AddWithValue("@proba", proba);
                        cmd.Parameters.AddWithValue("@varsta", categorieVarsta);


                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                participanti.Add(new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3)));
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.FindParticipantiByProba_Varsta(" + proba + ", " + categorieVarsta + ")");
            return participanti;
        }

        public void Save(Participant entity)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.Save(entity) where entity: "+entity.ToString());
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "insert into Participanti(Nume,Varsta) values (@nume,@varsta)";
                        cmd.Parameters.AddWithValue("@nume", entity.Nume);
                        cmd.Parameters.AddWithValue("@varsta", entity.Varsta);

                        cmd.ExecuteNonQuery();

                    }                

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.Save(entity) where entity: " + entity.ToString());

        }

        public int Size()
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.Size()");
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select count(*) as [SIZE] from Participanti";
                        int size = cmd.ExecuteNonQuery();

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            logger.Info("Exit: RepositoryJdbcParticipanti.Size()");
                            return rdr.GetInt32(0);
                        }
                    }                   
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.Size()");
            return 0;
        }



        public void Update(Participant entity)
        {
            logger.Info("Entry: RepositoryJdbcParticipanti.Update(entity) where entity: " + entity.ToString());
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "update Participanti set NumarParticipari=@nrpart where ID=@id";
                        cmd.Parameters.AddWithValue("@id", entity.ID);
                        cmd.Parameters.AddWithValue("@nrpart", entity.NumarParticipari);

                        int size = cmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();

                    }                        

                }

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcParticipanti.Update(entity) where entity: " + entity.ToString());

        }

        public Participant FindLastAdded()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Participanti\n" +
                                          "order by ID desc\n" +
                                          "limit 1";

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            return new Participant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3));
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
    }
}
