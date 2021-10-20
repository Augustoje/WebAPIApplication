using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApplication.Model
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseData { get; set; }
        public string genre { get; set; }
        public decimal Price { get; set; }
    }
}
