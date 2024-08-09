using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food_Project.Classes
{
    public class RecommendationFood
    {
        private Food food;
        private double portionSize;
        private Timing timing;
        private int beforeRating;
        private int afterRating;

        public RecommendationFood() { }

        public RecommendationFood(Food food, double portionSize, Timing timing, int beforeRating, int afterRating)
        {
            this.food = food;
            this.portionSize = portionSize;
            this.timing = timing;
            this.beforeRating = beforeRating;
            this.afterRating = afterRating;
        }

        public Food Food { get => food; set => food = value; }
        public double PortionSize { get => portionSize; set => portionSize = value; }
        public Timing Timing { get => timing; set => timing = value; }
        public int BeforeRating { get => beforeRating; set => beforeRating = value; }
        public int AfterRating { get => afterRating; set => afterRating = value; }

        public override string ToString()
        {
            return $"{this.food.FoodName} {this.portionSize} {this.timing} {this.beforeRating} {this.afterRating}";
        }
    }
}
