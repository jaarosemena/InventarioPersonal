namespace InventarioPersonal.CLI.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public DateTime FechaCreacion { get; set; }

    // Constructor con parámetros
    public Producto(int id, string nombre, string descripcion, int cantidad, decimal precioUnitario)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
        FechaCreacion = DateTime.Now;
    }

    // Constructor vacío (necesario para algunos escenarios)
    public Producto()
    {
        FechaCreacion = DateTime.Now;
    }
}