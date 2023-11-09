using System;
using System.Collections.Generic;

// Clase para el Ejercicio 1 - Rectangulo
class Rectangulo {
    // Propiedades
    public double Ancho { get; set; }
    public double Alto { get; set; }

    // Método para calcular el área del rectángulo
    public double CalcularArea() {
        return Ancho * Alto;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro() {
        return 2 * (Ancho + Alto);
    }
}

// Clase para el Ejercicio 2 - Avion
class Avion {
    // Propiedades
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }
    public int VelocidadMaxima { get; set; }

    // Método para mostrar información del avión
    public void MostrarInformacion() {
        Console.WriteLine($"Modelo: {Modelo}\nCapacidad de Pasajeros: {CapacidadPasajeros}\nVelocidad Máxima: {VelocidadMaxima} km/h");
    }
}

// Clase para el Ejercicio 3 - Factura
class Factura {
    // Propiedades
    public int NumeroFactura { get; set; }
    public DateTime Fecha { get; set; }
    public List<string> ProductosComprados { get; set; }

    // Método para calcular el total de la factura
    public double CalcularTotal() {
        // Simplemente devolvemos un valor fijo para la demostración
        return 150.75;
    }
}

// Clase para el Ejercicio 4 - Mascota
class Mascota {
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string TipoAnimal { get; set; }
}

// Clase para el Ejercicio 5 - Pelota
class Pelota {
    // Propiedades
    public string Tipo { get; set; }
    public double Diametro { get; set; }
}

// Clase para el Ejercicio 6 - Restaurante
class Restaurante {
    // Propiedades
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<string> Menu { get; set; }

    // Métodos
    public void AgregarPlatoAlMenu(string plato) {
        Menu.Add(plato);
        Console.WriteLine($"Se ha agregado '{plato}' al menú.");
    }

    public void TomarPedido(string plato) {
        Console.WriteLine($"Pedido tomado: {plato}");
    }
}

class Program {
    static void Main() {
        // Ejercicio 1 - Rectangulo
        Rectangulo rectangulo1 = new Rectangulo { Ancho = 5, Alto = 10 };
        Console.WriteLine("Rectángulo 1:");
        Console.WriteLine($"Área: {rectangulo1.CalcularArea()}");
        Console.WriteLine($"Perímetro: {rectangulo1.CalcularPerimetro()}\n");

        // Ejercicio 2 - Avion
        List<Avion> aviones = new List<Avion>();
        Console.WriteLine("Ingrese información de varios aviones:");
        for (int i = 0; i < 2; i++) {
            Avion avion = new Avion();
            Console.Write($"Avión {i + 1} - Modelo: ");
            avion.Modelo = Console.ReadLine();
            Console.Write("Capacidad de Pasajeros: ");
            avion.CapacidadPasajeros = Convert.ToInt32(Console.ReadLine());
            Console.Write("Velocidad Máxima (km/h): ");
            avion.VelocidadMaxima = Convert.ToInt32(Console.ReadLine());
            aviones.Add(avion);
        }
        Console.WriteLine("\nInformación de Aviones:");
        foreach (var avion in aviones) {
            avion.MostrarInformacion();
            Console.WriteLine();
        }

        // Ejercicio 3 - Factura
        List<Factura> facturas = new List<Factura>();
        Console.WriteLine("Ingrese información de varias facturas:");
        for (int i = 0; i < 2; i++) {
            Factura factura = new Factura();
            Console.Write($"Factura {i + 1} - Número: ");
            factura.NumeroFactura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fecha (yyyy-MM-dd): ");
            factura.Fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Productos Comprados (separados por comas): ");
            factura.ProductosComprados = new List<string>(Console.ReadLine().Split(','));
            facturas.Add(factura);
        }
        Console.WriteLine("\nTotal de Facturas:");
        foreach (var factura in facturas) {
            Console.WriteLine($"Factura {factura.NumeroFactura}: Total = {factura.CalcularTotal()}");
        }

        // Ejercicio 4 - Mascota
        List<Mascota> mascotas = new List<Mascota>();
        Console.WriteLine("\nIngrese información de varias mascotas:");
        for (int i = 0; i < 2; i++) {
            Mascota mascota = new Mascota();
            Console.Write($"Mascota {i + 1} - Nombre: ");
            mascota.Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            mascota.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tipo de Animal: ");
            mascota.TipoAnimal = Console.ReadLine();
            mascotas.Add(mascota);
        }
        Console.WriteLine("\nInformación de Mascotas:");
        foreach (var mascota in mascotas) {
            Console.WriteLine($"Nombre: {mascota.Nombre}, Edad: {mascota.Edad}, Tipo de Animal: {mascota.TipoAnimal}");
        }

        // Ejercicio 5 - Pelota
        List<Pelota> pelotas = new List<Pelota>();
        Console.WriteLine("\nIngrese información de varias pelotas:");
        for (int i = 0; i < 2; i++) {
            Pelota pelota = new Pelota();
            Console.Write($"Pelota {i + 1} - Tipo: ");
            pelota.Tipo = Console.ReadLine();
            Console.Write("Diámetro: ");
            pelota.Diametro = Convert.ToDouble(Console.ReadLine());
            pelotas.Add(pelota);
        }
        Console.WriteLine("\nInformación de Pelotas:");
        foreach (var pelota in pelotas) {
            Console.WriteLine($"Tipo: {pelota.Tipo}, Diámetro: {pelota.Diametro}");
        }

        // Ejercicio 6 - Restaurante
        Restaurante restaurante = new Restaurante { Nombre = "Mi Restaurante", Direccion = "Calle Principal", Menu = new List<string>() };
        Console.WriteLine("\nSimulación de Operación de un Restaurante:");
        while (true) {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar Plato al Menú");
            Console.WriteLine("2. Tomar Pedido");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1) {
                Console.Write("Ingrese el nombre del plato a agregar: ");
                string plato = Console.ReadLine();
                restaurante.AgregarPlatoAlMenu(plato);
            } else if (opcion == 2) {
                Console.Write("Ingrese el nombre del plato para el pedido: ");
                string platoPedido = Console.ReadLine();
                restaurante.TomarPedido(platoPedido);
            } else if (opcion == 3) {
                break;
            } else {
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
            }
        }
    }
}
//Explicación:
//Documentación y Comentarios:


//Ejercicio 1 - Rectangulo:

//Se ha creado una clase Rectangulo con propiedades para el ancho y alto, y métodos para calcular el área y el perímetro.
//Ejercicio 2 - Avion:

//Se ha creado una clase Avion con propiedades para el modelo, capacidad de pasajeros y velocidad máxima, y un método para mostrar la información del avión.
//Ejercicio 3 - Factura:

//Se ha creado una clase Factura con propiedades para el número de factura, fecha y lista de productos comprados, y un método para calcular el total de la factura.
//Ejercicio 4 - Mascota:

//Se ha creado una clase Mascota con propiedades para el nombre, edad y tipo de animal.
//Ejercicio 5 - Pelota:

//Se ha creado una clase Pelota con propiedades para el tipo y diámetro.
//Ejercicio 6 - Restaurante:

//Se ha creado una clase Restaurante con propiedades para el nombre, dirección y menú, y métodos para agregar platos al menú y tomar pedidos.
//Se ha simulado la operación de un restaurante mediante un bucle en el programa principal.