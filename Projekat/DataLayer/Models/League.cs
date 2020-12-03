using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    class League
    {
        public class League
        {
            private int Id ;
            private string Name;
            private int Points ;
            private string Couch;

            public League(string id, string Name, string Couch, int Points)
            {
                Id = Id;
                Name = name;
                Couch = couch;
                Points = points;
            }
            
        
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string couch
        {
            get { return Couch; }
            set { Couch = value; }
        }
        public int points
        {
            get { return Points; }
            set { Points = value; }
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Couch} {Points}";
        }

}
}

    }

