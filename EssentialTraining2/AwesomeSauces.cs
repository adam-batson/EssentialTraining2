using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining2
{
    public class AwesomeSauces
    {
        public List<string> Sauces { get; set; }
        public AwesomeSauces()
        {
            Sauces = new List<string>();
        }
        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }

    }
}
