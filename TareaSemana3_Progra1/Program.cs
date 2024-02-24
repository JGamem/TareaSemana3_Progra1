using System.Security.Cryptography;

byte option = 0;
do
{
    if (option is < 1 or > 12)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ingresa una opción: \n\n");
        Console.WriteLine("Evitando errores con try catch\n");
        Console.WriteLine("1. Calcular el Mayor de Tres Números");
        Console.WriteLine("2. Validar Edad para Ingresar a un Club");
        Console.WriteLine("3. Calcular el Precio Final de un Producto");
        Console.WriteLine("4. Validar Usuario y Contraseña");
        Console.WriteLine("5. Determinar si un Número es Par o Impar");
        Console.WriteLine("6. Mostrar un Mensaje de Aprobación o Rechazo de Préstamo");
        Console.WriteLine("7. Calcular el Área de una Figura Geométrica");
        Console.WriteLine("\nEjercicios usando switch\n");
        Console.WriteLine("8. Convertir un Número de Letra a Número");
        Console.WriteLine("9. Mostrar el Día de la Semana a partir de un Número");
        Console.WriteLine("10. Calcular el Importe a Pagar por un Servicio");
        Console.WriteLine("11. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas");
        Console.WriteLine("12. Evaluar la Calificación de un Examen");
        Console.WriteLine("99. Salir");
    }
    if (byte.TryParse(Console.ReadLine(), out option))
    {
        switch (option)
        {
            case 1:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Digita tu primer número");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digita tu segundo número");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digita tu tercer número");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    if (num1 > num2)
                    {
                        if (num1 > num3)
                        {
                            Console.WriteLine("El mayor de los números es {0}", num1);
                        }
                    }
                    else if (num2 > num3)
                    {
                        Console.WriteLine("El numero mayor es: {0}", num2);
                    }
                    else
                    {
                        Console.WriteLine("El numero mayor es: {0}", num3);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debes ingresar números enteros.");
                }
                break;
            case 2:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa tu edad: ");
                    byte age= Convert.ToByte(Console.ReadLine());

                    if (age >= 18 )
                    {
                        Console.WriteLine("Dale papito, pasa adelante");
                    }
                    else
                    {
                        Console.WriteLine("Tuavia estas muy chiquito papa no tenes 18");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debes ingresar una edad correcta!");
                }
                break;
            case 3:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el precio del producto: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    if (price > 100)
                    {
                        double discount = Math.Round((price * 0.10),2);
                        double newPrice = price - (price * 0.10);
                        Console.WriteLine("Obtuviste un descuento de Q{0} por tu compra mayor a Q100",discount);
                        Console.WriteLine("Total a pagar: Q{0}",newPrice);
                    }
                    else
                    {
                        Console.WriteLine("Total a pagar: Q{0}",price);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debes ingresar una edad correcta!");
                }
                break;
            case 4:
                try
                {
                    Console.Clear();
                    string user = "admin";
                    string password = "passw0rd123";
                    Console.WriteLine("Ingresa el usuario: ");
                    string? userInsert = Console.ReadLine();
                    Console.WriteLine("Ingresa tu contrasenia: ");
                    string? pswdInsert = Console.ReadLine();

                    if (userInsert == user && pswdInsert== password)
                    {
                        Console.WriteLine("Inicio de sesion exitoso! pase adelante ");
                    }
                    else
                    {
                        throw new Exception("Usuario o contrasenia no validos, intente otra vez");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}",ex.Message);
                }
                break;
            case 5:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un número entero:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("{0} es un número par.", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} es un número impar.", number);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            case 6:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Cual es el monto de su prestamo? ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese su edad: ");
                    byte age = Convert.ToByte(Console.ReadLine());

                    if (amount < 5000 || age > 60)
                    {
                        Console.WriteLine("Su prestamo fue aprobado con exito!");
                    }
                    else
                    {
                        Console.WriteLine("No cumples con los requisitos, hoy no se presta mañana si");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un monto y/o edad valida");
                }
                break;
            case 7:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Selecciona el tipo de figura geométrica:");
                    Console.WriteLine("1. Triángulo");
                    Console.WriteLine("2. Cuadrado");
                    Console.WriteLine("3. Círculo");
                    int op = Convert.ToInt32(Console.ReadLine());

                    double area = 0;

                    if (op == 1)
                    {
                        Console.WriteLine("Ingresa la base del triángulo:");
                        double baseTriangle = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa la altura del triángulo:");
                        double heightTriangle = Convert.ToDouble(Console.ReadLine());
                        area = (baseTriangle * heightTriangle) / 2;
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Ingresa el lado del cuadrado:");
                        double sideSquare = Convert.ToDouble(Console.ReadLine());
                        area = sideSquare * sideSquare;
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine("Ingresa el radio del círculo:");
                        double radiusCircle = Convert.ToDouble(Console.ReadLine());
                        area = Math.PI * Math.Pow(radiusCircle, 2);
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                        return;
                    }

                    Console.WriteLine("El área de la figura es: {0}", Math.Round(area,2));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debes ingresar un número válido.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            case 8:
                Console.Clear();
                Console.WriteLine("Ingresa un número del 1 al 5 en palabras:");
                string textNumber = Console.ReadLine().ToLower();
                int num = ConvertToNumber(textNumber);

                Console.WriteLine("El número ingresado es: {0}", num);
                break;
            case 9:
                Console.Clear();
                Console.WriteLine("Ingresa un numero del 1 al 7");
                int weekDay = Convert.ToInt32(Console.ReadLine());
                string day = DayOfTheWeek(weekDay);
                Console.WriteLine("El dia ingresado es {0}", day);
                break;
            case 10:
                Console.Clear();
                Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
                string typeService = Console.ReadLine();
                double importe = CalculateAmount(typeService);
                if (importe >= 0)
                {
                    Console.WriteLine("El importe a pagar es: Q" + importe);
                }
                else
                {
                    Console.WriteLine("Tipo de servicio inválido.");
                }
                break;
            case 11:
                Console.Clear();
                Console.WriteLine("Seleccione su idioma de preferencia (español, inglés, francés, ruso, japonés o italiano):");
                string idioma = Console.ReadLine();

                MostrarMensajeBienvenida(idioma);
                break;
            case 12:
                Console.Clear();
                Console.WriteLine("Ingrese la calificación del examen:");
                string entrada = Console.ReadLine();

                EvaluarCalificacion(entrada);
                break;
        }

    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor, ingrese una opcion válida");
        Thread.Sleep(2000);
    }

    //Ejercicios usando switch
static int ConvertToNumber(string text)
{
    switch (text)
    {
        case "uno":
            return 1;
        case "dos":
            return 2;
        case "tres":
            return 3;
        case "cuatro":
            return 4;
        case "cinco":
            return 5;
        default:
            return 0;
    }
}

static string DayOfTheWeek (int number)
    {
        string dia = "";
        switch (number)
        {
            case 1:
                dia = "Lunes";
                break;
            case 2:
                dia = "Martes";
                break;
            case 3:
                dia = "Miércoles";
                break;
            case 4:
                dia = "Jueves";
                break;
            case 5:
                dia = "Viernes";
                break;
            case 6:
                dia = "Sábado";
                break;
            case 7:
                dia = "Domingo";
                break;
            default:
                dia = "Número inválido";
                break;
        }
        return dia;
    }
static double CalculateAmount(string tipoServicio)
    {
        double importe = 0;

        switch (tipoServicio.ToLower())
        {
            case "lavado de auto":
                importe = 50.0;
                break;
            case "cambio de aceite":
                importe = 100.0;
                break;
            case "revisión mecánica":
                importe = 200.0;
                break;
            default:
                importe = -1; // Valor negativo para indicar un tipo de servicio inválido
                break;
        }

        return importe;
    }
static void MostrarMensajeBienvenida(string idioma)
    {
        switch (idioma.ToLower())
        {
            case "español":
                Console.WriteLine("¡Bienvenido!");
                break;
            case "ingles":
                Console.WriteLine("Welcome!");
                break;
            case "frances":
                Console.WriteLine("Bienvenue!");
                break;
            case "ruso":
                Console.WriteLine("Добро пожаловать!");
                break;
            case "japones":
                Console.WriteLine("ようこそ!");
                break;
            case "italiano":
                Console.WriteLine("Benvenuto!");
                break;
            default:
                Console.WriteLine("Idioma no reconocido.");
                break;
        }
    }
static void EvaluarCalificacion(string calificacionStr)
    {
        if (int.TryParse(calificacionStr, out int calificacion))
        {
            switch (calificacion)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("Sobresaliente");
                    break;
                case int n when (n >= 80 && n <= 89):
                    Console.WriteLine("Notable");
                    break;
                case int n when (n >= 70 && n <= 79):
                    Console.WriteLine("Aprobatoria");
                    break;
                case int n when (n >= 60 && n <= 69):
                    Console.WriteLine("No aprobatoria");
                    break;
                case int n when (n < 60 && n > 25):
                    Console.WriteLine("Perdiste chavito, pero te recuperas en el segundo");
                    break;
                case int n when (n < 25 && n > 0):
                    Console.WriteLine("No llegaste a nota minima mi brocoli, quedas fuera");
                    break;
                default:
                    Console.WriteLine("Calificación fuera de rango");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero.");
        }
    }

} while (option!=99);