using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RMovie.PCL.Models;

namespace RMovie.Controllers
{
    public class RMovieController : ApiController
    {
        // GET api/values
        public ICollection<LineModel> Get()
        {
            return ViewModels.ViewModelLocator.SeatVM.LineCollection;
        }
    }
}