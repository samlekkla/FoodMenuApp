using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupparbeteFoodapplication.Classes
{
    public class RecipeType 
    {
        public string FoodType { get; set; }
                
        public RecipeType(string foodType)
        {
            FoodType = foodType;
        }

        

        public override string ToString()
        {
            return FoodType;
        }

        
    }

 
}
