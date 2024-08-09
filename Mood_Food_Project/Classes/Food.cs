using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food_Project.Classes
{
    public class Food
    {
        private string foodName;
        private string foodType;
        private string allergy;


        public Food() { }

        public Food(string foodName, string foodType, string allergies)
        {
            this.foodName = foodName;
            this.foodType = foodType;
            this.allergy = allergies;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodType { get => foodType; set => foodType = value; }
        public string Allergy { get => allergy; set => allergy = value; }

        public bool Equals(Food other)
        {
            // Comparing the two food object and if they are equal then returing true; else returning false.
            if (this.foodName == other.foodName && this.foodType == other.foodType && this.allergy == other.allergy)
            {
                return true;
            }

            return false;
        }
        
        public string Display()
        {
            return $"Food Name: {foodName}, Food Type: {foodType}, Allergy = {allergy}" ;
        }
    }
}
