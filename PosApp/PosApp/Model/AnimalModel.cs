using System;
using System.Collections.Generic;
using System.Text;

namespace PosApp.Model
{
    public class AnimalModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
