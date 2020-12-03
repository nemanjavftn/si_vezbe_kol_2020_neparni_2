using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer.Models
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

        public int getSetId
        {
            get
            {
                return Id;
            }
            set
            {
                this.Id = Id;
            }
        }

        public string getSetName
        {
            get
            {
                return Name;
            }
            set
            {
                this.Name = Name;
            }
        }
        public string getSetCouch
        {
            get
            {
                return Couch;
            }
            set
            {
                this.Couch = Couch;
            }
        }
        public int getSetPoints
        {
            get
            {
                return Points;
            }
            set
            {
                this.Points = Points;
            }
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Couch} {Points}";
        }
    }
}
