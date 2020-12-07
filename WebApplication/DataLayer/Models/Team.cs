using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Team
    {
        private int Id;
        private string Name;
        private string Couch;
        private int Points;

        public Team(int id, string name, string couch, int points)
        {
            Id = id;
            Name = name;
            Couch = couch;
            Points = points;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Couch1 { get => Couch; set => Couch = value; }
        public int Points1 { get => Points; set => Points = value; }


        public override string ToString()
        {
            return $"Id je : {Id}, Ime je : {Name}, Trener: {Couch}, Poena:{Points}";
        }
    }
}
