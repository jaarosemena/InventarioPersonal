using InventarioPersonal.CLI.Models;

Console.WriteLine("================================");
Console.WriteLine("   INVENTARIO PERSONAL v0.1    ");
Console.WriteLine("================================");
Console.WriteLine();

// Crear una lista de productos
List<Producto> productos = new List<Producto>
{
    new Producto(1, "Laptop HP", "Laptop HP 15 pulgadas, 8GB RAM", 5, 899.99m),
    new Producto(2, "Mouse Logitech", "Mouse inalámbrico", 15, 29.99m),
    new Producto(3, "Teclado Mecánico", "Teclado mecánico RGB", 8, 79.99m),
    new Producto(4, "Monitor Samsung", "Monitor 24 pulgadas Full HD", 3, 199.99m)
};

// Mostrar los productos
Console.WriteLine($"Total de productos en inventario: {productos.Count}");
Console.WriteLine();
Console.WriteLine("─────────────────────────────────────────────────────────────────");
Console.WriteLine($"{"ID",-5} {"Nombre",-20} {"Cantidad",10} {"Precio",12} {"Total",12}");
Console.WriteLine("─────────────────────────────────────────────────────────────────");

foreach (var producto in productos)
{
    decimal total = producto.Cantidad * producto.PrecioUnitario;
    Console.WriteLine($"{producto.Id,-5} {producto.Nombre,-20} {producto.Cantidad,10} {producto.PrecioUnitario,12:C} {total,12:C}");
}

Console.WriteLine("─────────────────────────────────────────────────────────────────");

// Calcular valor total del inventario
decimal valorTotal = 0;
foreach (var producto in productos)
{
    valorTotal += producto.CalcularValorTotal();
}

Console.WriteLine($"{"Valor total del inventario:",49} {valorTotal,12:C}");
Console.WriteLine();
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();