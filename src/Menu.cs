
using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish plato)
        {
            this.dishes.Add(plato);
        }

        public void RemoveDish(Dish plato)
        {
            this.dishes.Remove(plato);
        }

        public Dish GetDishByName(string nombre)
        {
            foreach (var plato in this.dishes)
            {
                if (plato.Name == nombre)
                {
                    return plato;
                }
            }
            return null;        
        }
    }
}
