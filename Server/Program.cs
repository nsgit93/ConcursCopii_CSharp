using System;
using Domain;
using Domain.Validator;
using Persistence;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Hashtable = System.Collections.Hashtable;
using System.Collections;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main(string[] args)
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 55555;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);

            string sqliteDBFileName = @System.Configuration.ConfigurationManager.AppSettings["jdbc.url"];
            string log4netconfig = System.Configuration.ConfigurationManager.AppSettings["log4net.xmlconfig"];
            IParticipantiRepository repoParticipanti = new RepositoryParticipanti(sqliteDBFileName, log4netconfig);
            IParticipariRepository repoParticipari = new RepositoryParticipari(sqliteDBFileName);
            IOrganizatoriRepository repoOrganizatori = new RepositoryOrganizatori(sqliteDBFileName, log4netconfig);
            IValidator<Participant> validator = new ValidatorParticipant();
            var server = new Service(repoOrganizatori, repoParticipanti, repoParticipari, validator);

            RemotingServices.Marshal(server, "Server");
            Console.WriteLine("Server started ...");
            Console.ReadLine();
            Console.WriteLine("Press <enter> to exit...");

        }
    }
}
