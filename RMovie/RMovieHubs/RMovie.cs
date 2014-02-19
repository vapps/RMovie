using SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RMovie.RMovieHubs
{
    public class RMovie
    {
        //private readonly static Lazy<RMovie> _instance = new Lazy<RMovie>(() => new RMovie());
        //public static List<Client> Clients = new List<Client>();

        //public static RMovie Instance
        //{
        //    get
        //    {
        //        return _instance.Value;
        //    }
        //}

        //public void SpreadMessage(string message)
        //{
        //    BroadCastMessage(message);
        //}

        //private void BroadCastMessage(string message)
        //{
        //    var clients = Hub.GetClients<RMovieHub>();

        //    clients.newMessage(message);
        //    clients.isAlive();
        //}

        //public void GetClients()
        //{
        //    System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //    string sJSON = oSerializer.Serialize(Clients);

        //    var clients = Hub.GetClients<RMovieHub>();
        //    clients.userList(sJSON);
        //}
    }
}