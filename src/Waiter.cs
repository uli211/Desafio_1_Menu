using System.Collections;

namespace Ucu.Poo.CrcCards;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();

    private Menu menu;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Waiter"/>.
    /// </summary>
    /// <param name="name">El nombre del mozo.</param>
    /// <param name="menu">El menú que usa el mozo.</param>
    public Waiter(string name, Menu menu)
    {
        this.Name = name;
        this.menu = menu;
    }

    /// <summary>
    /// Implementa la responsabilidad de conocer las mesas asignadas al mozo.
    /// Retorna una copia de la lista real para dejar el original encapsulado.
    /// </summary>
    public ArrayList AssignedTables
    {
        get
        {
            return (ArrayList)this.assignedTables.Clone();
        }
    }

    /// <summary>
    /// Implementa la responsabilidad de conocer el nombre del mozo.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Implementa la responsabilidad de asignar una mesa al mozo.
    /// </summary>
    /// <param name="table">La mesa a asignar.</param>
    public void AssignTable(Table table)
    {
        if (table != null)
        {
            this.assignedTables.Add(table);
            table.Occupy();
        }
    }

    /// <summary>
    /// Implementa la responsabilidad de tomar un pedido para una mesa
    /// específica y agregar el platillo a la orden de esa mesa.
    /// </summary>
    /// <param name="table">La mesa a agregar el platillo.</param>
    /// <param name="dishName">El nombre del platillo ordenado por la mesa.
    /// </param>
    public void TakeOrder(Table table, string dishName)
    {
        if (table != null && table.Order != null)
        {
            Dish dish = this.menu.GetDishByName(dishName);
            table.Order.AddDish(dish);
        }
    }
}
