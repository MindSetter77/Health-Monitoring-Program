using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MealCalculator
{
    public static double EstimateCalories(double weight, double caloriesPer100g)
    {
        return weight * (caloriesPer100g / 100);
    }
}
