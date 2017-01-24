using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBuildTest.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string TagNumber { get; set; }
        public int Age { get; set; }

        public void Bark()
        {
            
        }
    }
}