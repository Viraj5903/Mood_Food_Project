using Mood_Food_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food_Project
{
    public partial class Rating_Suggestion_Form : Form
    {
        private Food[] indianFood = {
            new Food("Pav Bhaji", "Indian", "None"),
            new Food("Dosa", "Indian", "None"),
            new Food("Dabeli", "Indian", "Peanuts"),
            new Food("Garlic Naan", "Indian", "Garlic"),
            new Food("Chaat", "Indian", "Tamarind"),
        };

        private Food[] mexican = {
            new Food("Chicken Flautas", "Mexician", "Cheese"),
            new Food("Pico De Galo", "Mexician", "None"),
            new Food("Refried Bean Tostadas", "Mexician", "Beans"),
            new Food("Flavoured Chicken Fajitas", "Mexician", "Guacamole"),
            new Food("Sopaipillas", "Mexican", "None"),
        };

        private Food[] american = {
            new Food("Cuban bread", "American", "None"),
            new Food("Jambalaya", "American", "Cheese"),
            new Food("Poke", "American", "Sesame"),
            new Food("Carne Asada Fries", "American", "Lime"),
            new Food("Carne Asada Burrito", "American", "Gucamole"),
        };
        
        private List<Food> selectedTypeFoods = new List<Food>();

        private List<RecommendationFood> ratedFoods = new List<RecommendationFood>();

        public Rating_Suggestion_Form()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxTypeOfFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clearing the previous stored items.
            comboBoxAllergy.Items.Clear();
            selectedTypeFoods.Clear();

            switch(comboBoxTypeOfFood.SelectedIndex)
            {
                case 0:
                    selectedTypeFoods.AddRange(indianFood);
                    break;

                case 1:
                    selectedTypeFoods.AddRange(mexican);
                    break;

                case 2:
                    selectedTypeFoods.AddRange(american);
                    break;
            }

            foreach(Food food in selectedTypeFoods)
            {
                // Adding the allergy into allergy combobox.
                if (!comboBoxAllergy.Items.Contains(food.Allergy))
                {
                    comboBoxAllergy.Items.Add(food.Allergy);
                }
            }

            comboBoxAllergy.Enabled = true;
        }

        private void comboBoxAllergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectFood.Items.Clear();
            comboBoxSelectFood.Enabled = true;

            foreach(Food food in selectedTypeFoods)
            {
                if (food.Allergy != comboBoxAllergy.Text || food.Allergy == "None")
                {
                    comboBoxSelectFood.Items.Add(food.FoodName);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                int beforeRating = comboBoxBeforeRating.SelectedIndex + 1;
                int afterRating = comboBoxAfterRating.SelectedIndex + 1;
                double portionSize = Convert.ToDouble(textBoxPortionSize.Text);

                if (portionSize <= 0)
                {
                    throw new Exception("Portion should be postive.");
                }

                if ((beforeRating <= 0 || beforeRating > 10) && (afterRating <= 0 || afterRating > 10))
                {
                    // MessageBox.Show("Rating must be between 1 to 10");
                    return;
                }

                if ((afterRating - beforeRating >= 1) && afterRating >= 5)
                {

                    Food foodToAdd = null;

                    // Finding the selected from the selectedTypeFoods and storing it into food variable.
                    foreach (Food foodSelected in selectedTypeFoods)
                    {
                        if (foodSelected.FoodName == comboBoxSelectFood.Text)
                        {
                            foodToAdd = foodSelected;
                            break;
                        }
                    }

                    // Adding the timing into timing variable.
                    Timing currentTiming = Timing.Night;

                    switch(comboBoxTiming.SelectedIndex)
                    {
                        case 0:
                            currentTiming = Timing.Morning;
                            break;
                        
                        case 1:
                            currentTiming = Timing.Afternoon;
                            break;

                        case 2:
                            currentTiming = Timing.Evening;
                            break;

                    }

                    // Creating the food recommendationFood.
                    RecommendationFood recommendationFoodToAdd = new RecommendationFood(foodToAdd, portionSize, currentTiming, beforeRating, afterRating);

                    // Finding whether the recommendationFood exist or not. If yes then storing the object reference into recommendationFoodExist variable.
                    RecommendationFood recommendationFoodExist = ratedFoods.FirstOrDefault(recommendationFoodElement => recommendationFoodElement.Food.Equals(foodToAdd));

                    if (recommendationFoodExist != null)
                    {
                        MessageBox.Show("Food already exist so changing the rating and timing with the new detail.");
                        // recommendationFoodExist = recommendationFoodToAdd;
                        ratedFoods.Remove(recommendationFoodExist);
                    }

                    else
                    {
                        ratedFoods.Add(recommendationFoodToAdd);
                        MessageBox.Show("Food Added.");
                    }

                    DisplayData();
                    Reset();
                }

                else
                {
                    MessageBox.Show("Invalid rating or rating increase criteria not met.");
                }
            }

            catch (Exception expection)
            {
                MessageBox.Show("Please enter valid detail.");
                MessageBox.Show(expection.Message);
            }

        }

        private void Reset()
        {
            DisplayData();

            //Changing the index of the allergy combo box first as it is depend on the typeofFoood Combobox because if we change index of the typeOfFood combo box then comboBoxTypeOfFood_SelectedIndexChanged() is called and it will make lofic error and allergy will be display after reset.
            comboBoxSelectFood.SelectedIndex = -1;
            comboBoxAllergy.SelectedIndex = -1;

            comboBoxTypeOfFood.SelectedIndex = -1;

            //comboBoxAllergy.SelectedIndex = -1;
            comboBoxAllergy.Items.Clear();
            comboBoxAllergy.Enabled = false;

            //comboBoxSelectFood.SelectedIndex = -1;
            comboBoxSelectFood.Items.Clear();
            comboBoxSelectFood.Enabled = false;

            
            textBoxPortionSize.Clear();

            comboBoxTiming.Enabled = false;
            comboBoxTiming.SelectedIndex = -1;

            comboBoxBeforeRating.SelectedIndex = -1;
            comboBoxAfterRating.SelectedIndex = -1;

            comboBoxBeforeRating.Enabled = false;
            comboBoxAfterRating.Enabled = false;
        }

        private void comboBoxSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBeforeRating.Enabled = true;
            comboBoxAfterRating.Enabled = true;
            comboBoxTiming.Enabled = true;
            textBoxPortionSize.Enabled = true;
        }

        private void DisplayData()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Food Name");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Timing");
            dataTable.Columns.Add("Before Mood");
            dataTable.Columns.Add("After Mood");

            foreach(RecommendationFood recommendationFood in ratedFoods)
            {
                dataTable.Rows.Add(recommendationFood.Food.FoodName, recommendationFood.Food.FoodType, recommendationFood.Timing ,recommendationFood.BeforeRating, recommendationFood.AfterRating);
            }

            dataGridViewFoods.DataSource = dataTable;
        }

        private void buttonSuggestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (ratedFoods.Count == 0)
                {
                    MessageBox.Show("Please enter the rating of the first.");
                    return;
                }

                int currentMood = comboBoxCurrentMood.SelectedIndex + 1;

                if (currentMood < 0)
                {
                    throw new Exception("Please enter the current mood.");
                }

                List<RecommendationFood> foodToRecommendation = new List<RecommendationFood>();

                foreach(RecommendationFood foodRecommendation in ratedFoods) 
                {
                    if (foodRecommendation.AfterRating > currentMood)
                    {
                        foodToRecommendation.Add(foodRecommendation);
                    }
                }

                if (foodToRecommendation.Count == 0)
                {
                    MessageBox.Show("No food available for this mood.");
                    recommendationLabel.Text = "No food available for this mood.";
                    return;
                }

                Random random = new Random();
                RecommendationFood suggestedFood = foodToRecommendation[random.Next(foodToRecommendation.Count)];

                recommendationLabel.Text = $"Try {suggestedFood.Food.FoodName} food.";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}