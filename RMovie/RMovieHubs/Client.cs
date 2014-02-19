using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace RMovie.RMovieHubs
{
    public class Client
    {
        public string Name { get; set; }
        [ScriptIgnore]
        public DateTime LastResponse { get; set; }
    }
}