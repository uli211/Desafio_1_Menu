namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public Dish(string name, double price, bool isVegetarian)
    {
        Name = name;
        Price = price;
        IsVegetarian = isVegetarian;
    }
    
    public string Name { get; set; }
    
    public double Price { get; set; }
    
    public bool IsVegetarian { get; set; }
    
}