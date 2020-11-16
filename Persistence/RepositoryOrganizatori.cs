using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using log4net;
using log4net.Config;


namespace Persistence
{
    public class RepositoryOrganizatori : IOrganizatoriRepository
    {
        /*private static ILog logger = LogManager.GetLogger;
        private JdbcUtils dbUtils;*/
        private string DBurl;

        private static readonly ILog logger = LogManager.GetLogger(typeof(RepositoryParticipanti));


        public RepositoryOrganizatori(string url, string log4netconfig)
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo(log4netconfig));
            logger.Info("Initializing RepositoryJdbcParticipanti with DB URI: " + url);
            DBurl = url;
        }


        public int Size()
        {
            //logger.traceEntry();
            //Connection con=dbUtils.getConnection();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select count(*) as [SIZE] from Organizatori";
                        int size = cmd.ExecuteNonQuery();
                        /*cmd.Parameters.AddWithValue("@name", "BMW");
                        cmd.Parameters.AddWithValue("@price", 36600);*/

                        cmd.Prepare();
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

        public Organizator FindOneByUserName(string userName)
        {
            logger.Info("Entry: RepositoryJdbcOrganizatori.FindOneByUserName(" + userName + ")");
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Organizatori where User=@user";
                        cmd.Parameters.AddWithValue("@user", userName);

                        int size = cmd.ExecuteNonQuery();

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();

                            logger.Info("Exit: RepositoryJdbcOrganizatori.FindOneByUserName(" + userName + ")");

                            return new Organizator(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
                        }
                            
                    }                        
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
            logger.Info("Exit: RepositoryJdbcOrganizatori.FindOneByUserName(" + userName + ")");
            return null;
        }

        public Organizator FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<Organizator> FindAll()
        {
            logger.Info("Entry: RepositoryJdbcOrganizatori.FindAll()");
            List<Organizator> organizatori = new List<Organizator>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DBurl))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(connection))
                    {
                        cmd.CommandText = "select * from Organizatori";

                        cmd.ExecuteNonQuery();

                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                organizatori.Add(new Organizator(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)));
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
            logger.Info("Exit: RepositoryJdbcOrganizatori.FindAll()");
            return organizatori;
        }

        public void Save(Organizator entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Organizator entity)
        {
            throw new NotImplementedException();
        }
    }
}
