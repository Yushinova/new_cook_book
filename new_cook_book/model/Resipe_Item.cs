﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_cook_book
{
    [Serializable]
    public class Resipe_Item
    {
        public string ImageSourse { get; set; }
        public string Name { get; set; }

        public List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> GetRecipes() { return recipes; }
        //public void SetRecipe(Recipe recipe) { recipes.Add(recipe); }
        //public void DelRecipe(int ind) { recipes.RemoveAt(ind); }
    }
    [Serializable]
    public class Recipe
    {
        public string ID { get; set; }
        public string NameResipe { get; set; }

        public List<string> ingredients = new List<string>();
        public void SetIngredients(List<string> ingredients)
        {
            foreach (var item in ingredients)
            {
                this.ingredients.Add(item);
            }
        }
        public List<string> GetIngredients() { return ingredients; }
        public override string ToString()
        {
            return $" {NameResipe} ID: {ID} ";
        }
    }
}
