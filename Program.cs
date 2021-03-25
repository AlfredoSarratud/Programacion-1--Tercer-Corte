using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, esta es la tercera actividad de programacion, la cual segun 4 variables de un perro, edad, tamaño, actividad y peso, te da el alimento diario recomendado.");


            string dato = "";
            int tamaño = 0;
            int actividad = 0;
            int edad = 0;
            int opcion = 0;
            double peso = 0;

            //El codigo es bastante largo, pero teniendo en cuenta que soy un principiante, estoy contento ya que cumple con los parametros a la perfeccion

            do
            {
                Console.WriteLine("Bienvenido, a continuacion le indicaremos cual seria la alimentacion ideal para su perro, teniendo en consideracion su tamaño y actividad diaria");
                Console.WriteLine();

                Console.WriteLine("Porfavor indique el tamaño e su perro");
                Console.WriteLine("1 = Miniatura");
                Console.WriteLine("2 = Pequeño");
                Console.WriteLine("3 = Mediano");
                Console.WriteLine("4 = Grande");
                dato = Console.ReadLine();
                tamaño = Convert.ToInt32(dato);
                Console.WriteLine();

                Console.WriteLine("Por favor indique el peso de su perro en kilogramos");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                Console.WriteLine();

                Console.WriteLine("Por favor indique como considera la actividad diaria de su perro");
                Console.WriteLine("1 = Baja");
                Console.WriteLine("2 = Media");
                Console.WriteLine("3 = Alta");
                dato = Console.ReadLine();
                actividad = Convert.ToInt32(dato);
                Console.WriteLine();

                Console.WriteLine("Por favor indique la edad de su perro en meses");
                dato = Console.ReadLine();
                edad = Convert.ToInt32(dato);
                Console.WriteLine();




                if (edad <= 12)
                {

                    switch (tamaño)
                    {

                        case 1:
                            if (edad <= 2)
                            {
                                Console.WriteLine("Su perro debe comer 50 gramos de comida diarios");
                            }
                            if (edad > 2 && edad < 12)
                            {
                                Console.WriteLine("Su perro debe comer 60 gramos de comida diarios");
                            }
                            if (edad > 5 && edad <= 12)
                            {
                                Console.WriteLine("Su perro debe comer 55 gramos de comida diarios");
                            }
                            break;

                        case 2:
                            if (peso >= 10 && peso < 10)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 95 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 110 gramos de comida diarios");
                                }
                                if (edad >= 4 && edad <= 5)
                                {
                                    Console.WriteLine("Su perro debe comer 115 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 110 gramos de comida diarios");
                                }
                            }
                            if (peso >= 5 && peso < 17)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 155 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 185 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 195 gramos de comida diarios");
                                }
                                if (edad > 4 && edad < 6)
                                {
                                    Console.WriteLine("Su perro debe comer 190 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 185 gramos de comida diarios");
                                }

                            }
                            break;

                        case 3:
                            if (peso >= 17 && peso < 25)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 215 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 265 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 285 gramos de comida diarios");
                                }
                                if (edad > 4 && edad < 6)
                                {
                                    Console.WriteLine("Su perro debe comer 285 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 280 gramos de comida diarios");
                                }
                            }
                            if (peso >= 25 && peso < 32)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 270 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 350 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 375 gramos de comida diarios");
                                }
                                if (edad > 4 && edad < 6)
                                {
                                    Console.WriteLine("Su perro debe comer 375 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 370 gramos de comida diarios");
                                }
                            }
                            if (peso >= 32 && peso < 40)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 300 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 400 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 445 gramos de comida diarios");
                                }
                                if (edad > 4 && edad < 6)
                                {
                                    Console.WriteLine("Su perro debe comer 450 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 450 gramos de comida diarios");
                                }
                            }
                            if (peso >= 40 && peso < 50)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 355 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 475 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 525 gramos de comida diarios");
                                }
                                if (edad > 4 && edad < 6)
                                {
                                    Console.WriteLine("Su perro debe comer 530 gramos de comida diarios");
                                }
                                if (edad > 5 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 530 gramos de comida diarios");
                                }
                            }
                            break;

                        case 4:
                            if (peso >= 50 && peso < 60)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 405 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 545 gramos de comida diarios");
                                }
                                if (edad > 3 && edad < 5)
                                {
                                    Console.WriteLine("Su perro debe comer 610 gramos de comida diarios");
                                }
                                if (edad > 4 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 625 gramos de comida diarios");
                                }
                            }
                            if (peso >= 60 && peso < 70)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 450 gramos de comida diarios");
                                }
                                if (edad > 2 && edad < 4)
                                {
                                    Console.WriteLine("Su perro debe comer 605 gramos de comida diarios");
                                }
                                if (edad > 3 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 685 gramos de comida diarios");
                                }
                            }
                            if (peso >= 70 && peso < 90)
                            {
                                if (edad <= 2)
                                {
                                    Console.WriteLine("Su perro debe comer 485 gramos de comida diarios");
                                }
                                if (edad > 2 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 670 gramos de comida diarios");
                                }
                            }
                            if (peso >= 90)
                            {
                                if (edad >= 2 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro debe comer 580 gramos de comida diarios");
                                }
                            }
                            break;
                    }
                }

                else
                {
                    switch (tamaño)
                    {

                        case 1:
                            switch (actividad)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 45 y 85 gramos de comida diarios");
                                    break;

                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 55 y 100 gramos de comida diarios");
                                    break;

                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de comida diarios");
                                    break;
                            }
                            break;

                        case 2:
                            switch (actividad)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 85 y 145 gramos de comida diarios");
                                    break;

                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 100 y 170 gramos de comida diarios");
                                    break;

                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de comida diarios");
                                    break;
                            }
                            break;

                        case 3:
                            if (peso >= 10 && peso < 15)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 145 y 195 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 170 y 225 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 190 y 225 gramos de comida diarios");
                                        break;
                                }
                            }
                            if (peso >= 15 && peso < 25)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 195 y 285 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 225 y 230 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de comida diarios");
                                        break;
                                }
                            }
                            if (peso >= 25 && peso < 40)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 285 y 410 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 330 y 475 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de comida diarios");
                                        break;
                                }
                            }
                            break;

                        case 4:
                            if (peso >= 40 && peso < 55)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 410 y 520 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 475 y 600 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de comida diarios");
                                        break;
                                }
                            }
                            if (peso >= 55 && peso < 70)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 520 y 620 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 600 y 720 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de comida diarios");
                                        break;
                                }
                            }
                            if (peso >= 70 && peso <= 90)
                            {
                                switch (actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 620 y 750 gramos de comida diarios");
                                        break;

                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 720 y 870 gramos de comida diarios");
                                        break;

                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de comida diarios");
                                        break;
                                }
                            }
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("NOTA: Si el sistema no es capaz de darle un resultado, es posible que haya datos incorrectos o que su perro tenga un peso por fuera de los rangos y deba ser llevado al veterinario por una dieta especializada");

                Console.WriteLine();
                Console.WriteLine("Inserte un 1 si desea continuar o un 0 si desea terminar el programa");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                Console.WriteLine();

            } while (opcion != 0);

            Console.ReadLine();
        }
    }
}
