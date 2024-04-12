using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Cat : Animal
    {
                
        public Cat(string name, string favoredFood):base(name,favoredFood)
        {
            
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf()+ "\nMEEOW";
        }
    }
}
