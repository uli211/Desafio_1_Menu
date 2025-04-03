namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();


    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }

    public void RemoveDish(Dish dish)
    {
        dishes.Remove(dish);
    }

    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in this.dishes)
        {
            if (dish.Name == name)
            {
                return dish;
            }
        }

        return null;
    }
}