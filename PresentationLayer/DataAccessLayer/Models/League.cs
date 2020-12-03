using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Couch { get; set; }
        public int Points { get; set; }
        
    }
}
