using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Crea un programa que presente un menú de opciones al usuario utilizando la sentencia switch. 
             * El menú debe permitir al usuario elegir entre diferentes opciones, como realizar una operación matemática, 
             * mostrar un mensaje o salir del programa.
             
            // Indicación al usuario
            Console.WriteLine("Hola bienvenido, del siguiente menu puedes escoger la opcion que desees");
            Console.WriteLine("---Menu---\n" +
                "--1. Sumar\n" +
                "--2. Restar\n" +
                "--3. Multiplicar\n" +
                "--4. Dividir\n" +
                "--5. Salir del programa");
            // Variable para controlar el bucle
            bool salir = false;
            // Inicio de bucle
            while (!salir) 
            { 
                // Programa le solicita al usuario que escoja una opción
                Console.WriteLine("\nIngresa el número de la ópcion que escogiste");
                string num1Escogido = Console.ReadLine();
                // Inicio de Switch
                switch (num1Escogido) {
                    case "1":
                        Console.WriteLine("Has escogido la opcion suma");
                        Console.WriteLine("Ingresa 1er número: ");
                        int num1_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa 2do número: ");
                        int num1_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma de {num1_1} y {num1_2} es {num1_1 + num1_2}");
                        break;
                    case "2":
                        Console.WriteLine("Has escogido la opcion resta");
                        Console.WriteLine("Ingresa 1er número: ");
                        num1_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa 2do número: ");
                        num1_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La resta de {num1_1} y {num1_2} es {num1_1 - num1_2}");
                        break;
                    case "3":
                        Console.WriteLine("Has escogido la opcion multiplicación");
                        Console.WriteLine("Ingresa 1er número: ");
                        num1_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa 2do número: ");
                        num1_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La multiplicación de {num1_1} y {num1_2} es {num1_1 * num1_2}");
                        break;
                    case "4":
                        Console.WriteLine("Has escogido la opcion división");
                        Console.WriteLine("Ingresa 1er número: ");
                        num1_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa 2do número: ");
                        num1_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La división de {num1_1} y {num1_2} es {(double)num1_1 / num1_2}");
                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("Gracias por usar el programa");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 5.");
                        break;
                }
            }
            Console.ReadKey();
            */


            /*
             * 2. Desarrolla un programa que solicite al usuario la longitud de los tres lados de un triángulo y luego 
             * clasifique el triángulo según su tipo (equilátero, isósceles, escaleno) utilizando la sentencia switch.
             
            // Indicación al usuario sobre el programa
            Console.WriteLine("Hola bienvenido. El siguiente programa te va a indicar tu tipo de triángulo");
            // Se solicita al usuario que ingrese los lados del triángulo
            Console.WriteLine("Ingresa el 1er lado de tu triángulo");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el 2do lado de tu triángulo");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el 3er lado de tu triángulo");
            double lado3 = double.Parse(Console.ReadLine());
            // Se declara la varaible
            int tipo = 0;
            // Condición para clasificar a los triángulos por tipo
            if (lado1 == lado2 && lado2 == lado3)
            {
                tipo = 1;
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                tipo = 2;
            }
            else {
                tipo = 3;
            }
            // Se imprima el tipo de tríangulo
            switch (tipo) {
                case 1: 
                    Console.WriteLine("Es un triángulo Equilatero");
                    break;
                case 2: 
                    Console.WriteLine("Es un triángulo Isoceles");
                    break;
                case 3:
                    Console.WriteLine("Es un triángulo Escaleno");
                    break;
            }
            Console.ReadKey();
            */


            /*
             * 3. Escribe un programa que solicite al usuario un número que represente un día de la semana (1 para lunes, 
             * 2 para martes, etc.) y muestre el nombre completo del día correspondiente utilizando la sentencia switch.
             
            // Indicación al usuario
            Console.WriteLine("Hola bienvenido, el siguiente programa es para que ingreses un número y " +
                "se te imprima a que día de la semana le pertenece");
            // Se solicita al usuario que ingrese un número
            Console.WriteLine("Ingresa un número del 1 al 7");
            int num3 = int.Parse(Console.ReadLine());
            // Valida el número ingresado e imprime un mensaje
            switch (num3) {
                case 1: Console.WriteLine($"{num3} pertenece al día Lunes");
                    break;
                case 2:
                    Console.WriteLine($"{num3} pertenece al día Martes");
                    break;
                case 3:
                    Console.WriteLine($"{num3} pertenece al día Miercoles");
                    break;
                case 4:
                    Console.WriteLine($"{num3} pertenece al día Jueves");
                    break;
                case 5:
                    Console.WriteLine($"{num3} pertenece al día Viernes");
                    break;
                case 6:
                    Console.WriteLine($"{num3} pertenece al día Sábado");
                    break;
                case 7:
                    Console.WriteLine($"{num3} pertenece al día Domingo");
                    break;
                default:
                    Console.WriteLine("Número ingresado no valido");
                    break;
            }
            Console.ReadKey();
            */


            /*
             * 4. Crea un programa que reciba la calificación numérica de un estudiante y muestre la 
             * letra equivalente de la calificación (A, B, C, D, F) utilizando la sentencia switch.
            
            // Bienvenida al usuario
            Console.WriteLine("Hola bienvenido. El programa cambia tu calicación de un número a una letra");
            // Se solicita al usuario que ingrese su calificación
            Console.WriteLine("Por favor ingresa tu calificación del 1 al 10");
            int calf = int.Parse(Console.ReadLine());
            // Se imprime el equivalente de la calificación en letra
            switch (calf)
            {
                case 10:
                case 9:
                    Console.WriteLine("Su nota equivalente es A");
                    break;
                case 8:
                    Console.WriteLine("Su nota equivalente es B");
                    break;
                case 7:
                    Console.WriteLine("Su nota equivalente es C");
                    break;
                case 6:
                    Console.WriteLine("Su nota equivalente es D");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Su nota equivalente es F");
                    break;
                default:
                    Console.WriteLine("Calificación ingresada no valida");
                    break;
            }
            Console.ReadKey();
            */


            /*
             * 5.Escribe un programa que solicite al usuario el nombre de una fruta y muestre un mensaje indicando 
             * si la fruta es cítrica o no utilizando la sentencia switch y una lista de frutas cítricas.
             
            Console.WriteLine("Bienvenido, el siguiente  programa te indicara si una fruta es cítrica o no");
            // Se crea una lista de frutas cítricas
            List<string> frutasCitricas = new List<string>
            { "naranja", "limón", "lima", "mandarina", "toronja" };
            // Se solicita al usuario que ingrese una fruta
            Console.WriteLine("Ingrese el nombre una fruta: ");
            string fruta = Console.ReadLine().ToLower();

            // Determinar si la fruta es o no cítrica
            switch(frutasCitricas.Contains(fruta))
            {
                case true:
                    Console.WriteLine("La fruta es cítrica");
                    break;
                case false:
                    Console.WriteLine("La fruta no es cítrica");
                    break;
            }
            Console.ReadKey();
            */


            /*
             * 6. Desarrolla un programa que simule un cajero automático. El programa debe solicitar al usuario 
             * la cantidad de dinero que desea retirar y verificar si tiene saldo suficiente. Si tiene saldo suficiente, 
             * se debe realizar la operación y actualizar el saldo. Utiliza la sentencia switch para controlar las diferentes 
             * opciones del cajero automático.
             
            // Indicaciones al usuario
            Console.WriteLine("Bienvenido. A tu Cajero Automático");
            Console.WriteLine("Elige una opción del siguiente menú:\n" +
                "1. Para consultar saldo\n" +
                "2. Para hacer depositos\n" +
                "3. Para hacer retiros");
            // Se solicita  al usuario que escoja una opción
            Console.Write("Ingresa tu opcion: ");
            int num6 = int.Parse(Console.ReadLine());
            // Se declara la variable de saldo inicial
            int saldo = 1000;
            // Realiza la opción que escogio el usuario
            switch (num6) 
            {
                case 1:
                    Console.WriteLine($"Tu saldo es ${saldo}");
                    break;
                case 2:
                    Console.WriteLine($"Tu saldo actual es ${saldo}");
                    Console.Write("Ingresa el valor a depositar: $");
                    int dep = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Tu nuevo saldo es ${saldo + dep}");
                    break;
                case 3:
                    Console.WriteLine($"Tu saldo actual es ${saldo}");
                    Console.Write("Ingresa el valor a retirar: $");
                    int ret = int.Parse(Console.ReadLine());
                    // Condición si el saldo es suficiente para hacer un retiro
                    if (ret <= saldo) 
                    {
                        Console.Write($"Tu nuevo saldo es ${saldo - ret}");
                    }
                    else 
                    {
                        Console.WriteLine("Saldo insuficiente. No procede");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.ReadLine();
            */


            /*
             * 7. Escribe un programa que solicite al usuario su edad y determine si tiene la edad suficiente para votar 
             * utilizando la sentencia switch. El programa debe mostrar un mensaje indicando si el usuario puede votar o no.
             
            // Indicaciones al usuario
            Console.WriteLine("Bienvenido. El programa te indicara si puedes votar");
            // Se solicita que ingrese su edad
            Console.WriteLine("Por favor ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            // Se declara una variable tipo bool para verificación de edad
            bool mayor = edad >= 18;
            // Se ejecuta switch para imprimir si puede votar
            switch (mayor) 
            {
                case true:
                    Console.WriteLine("Eres mayor de edad. Puedes votar");
                    break; 
                case false:
                    Console.WriteLine("Eres menor de edad. No puedes votar");
                    break;
            }
            Console.ReadKey();
            */


            /*
             * 8. Desarrolla un programa que calcule el precio final de un producto considerando un descuento por volumen. 
             * El programa debe solicitar al usuario la cantidad de unidades del producto y aplicar un descuento según la 
             * cantidad establecida. Utiliza la sentencia switch para determinar el descuento aplicable. 
             
            // Indicación al usuario
            Console.WriteLine("Bienvenido a tu tienda");
            Console.WriteLine("Aprovecha las siguientes promociones:\n" +
                "Por la compra de 3 a 5 productos tienes el 10% de descuento al total\n" +
                "Por la compra de 6 a 8 productos tienes el 15% de descuento al total\n" +
                "Por la compra de más de 9 productos tienes el 20% de descuento al total\n");

            // Solicitar al usuario la cantidad de productos comprados
            Console.WriteLine("Ingresa la cantidad de productos que has comprado:");
            int cantidad = int.Parse(Console.ReadLine());

            // Precio por unidad del producto
            double precioUnitario = 100.0; // Puedes ajustar este valor según el producto específico

            if (cantidad > 0)
            {
                // Determinar el porcentaje de descuento utilizando switch
                double descuentoPorcentaje = 0.0;

                switch (cantidad)
                {
                    case int n when (n >= 3 && n <= 5):
                        descuentoPorcentaje = 10.0;
                        break;
                    case int n when (n >= 6 && n <= 8):
                        descuentoPorcentaje = 15.0;
                        break;
                    default: // Para cantidades mayores a 9
                        if (cantidad > 8)
                        {
                            descuentoPorcentaje = 20.0;
                        }
                        break;
                }

                // Calcular el precio final después del descuento
                double precioSinDescuento = precioUnitario * cantidad;
                double precioFinal = precioSinDescuento * (1 - descuentoPorcentaje / 100);

                // Mostrar el resultado
                Console.WriteLine($"Usted ha comprado {cantidad} productos, tiene un descuento del {descuentoPorcentaje}%.");
                Console.WriteLine($"Precio sin descuento a pagar: ${precioSinDescuento:F2}");
                Console.WriteLine($"Precio final a pagar: ${precioFinal:F2}");
            }
            else
            {
                Console.WriteLine("Ingrese un valor válido.");
            }
            Console.ReadKey();
            */


            /*
             * 9. Crea un programa que simule una máquina expendedora. El programa debe mostrar un arreglo de productos con sus precios 
             * y permitir al usuario seleccionar un producto e ingresar el dinero correspondiente. Utiliza la sentencia switch para procesar 
             * la selección del producto, verificar el pago y entregar el producto simulado.
             
            // Definir productos y precios
            string[] productos = { "Coca-Cola", "Pepsi", "Agua", "Galleta", "Chocolate" };
            double[] precios = { 1.00, 0.95, 0.50, 0.60, 0.75 };

            // Mostrar productos y precios
            Console.WriteLine("Bienvenido a la máquina expendedora");
            Console.WriteLine("Seleccione un producto:");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]:F2}");
            }

            // Solicitar al usuario la selección del producto
            Console.Write("Ingrese el número del producto que desea comprar: ");
            int seleccion = int.Parse(Console.ReadLine());

            // Verificar si la selección es válida
            if (seleccion < 1 || seleccion > productos.Length)
            {
                Console.WriteLine("Selección inválida.");
                return;
            }

            // Solicitar el dinero insertado
            Console.Write("Ingrese el monto de dinero insertado: $");
            double dineroInsertado = double.Parse(Console.ReadLine());

            // Determinar el precio del producto seleccionado
            double precioProducto = precios[seleccion - 1];

            // Procesar la selección del producto
            switch (seleccion)
            {
                case 1: // Coca-Cola
                case 2: // Pepsi
                case 3: // Agua
                case 4: // Chips
                case 5: // Chocolate
                    if (dineroInsertado >= precioProducto)
                    {
                        double cambio = dineroInsertado - precioProducto;
                        Console.WriteLine($"Compra exitosa. Recoja su {productos[seleccion - 1]}.");
                        if (cambio > 0)
                        {
                            Console.WriteLine($"Su cambio es: ${cambio:F2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Fondos insuficientes. Necesita ${precioProducto - dineroInsertado:F2} más.");
                    }
                    break;
                default:
                    Console.WriteLine("Producto no disponible.");
                    break;
            }
            Console.ReadLine();
            */
        }
    }
}
