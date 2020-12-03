using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer4.Models
{
    public class TeamT
    {
        private int Id;
        private string Name;
        private string Couch;
        private int Points;

        public TeamT(int id, string name, string couch, int points)
        {
            Id1 = id;
            Name1 = name;
            Couch1 = couch;
            Points1 = points;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Couch1 { get => Couch; set => Couch = value; }
        public int Points1 { get => Points; set => Points = value; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Couch}-{Points}";
    }
    }
  
}
