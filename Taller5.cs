using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.captura();
            DateTime dat = DateTime.Now;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("La hora de ejecución es: {0:d} at {0:t}", dat);
            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine("La hora de la zona es: {0}\n",
            tz.IsDaylightSavingTime(dat) ?
            tz.DaylightName : tz.StandardName);
            Console.Write("Presione enter para salir del programa ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

        }
        // captura de variables y asignaciones
        int i;
        int j;
        int mg1;
        int mg2;



        int[,,] principal;
        double[,,] def;
        public int[,] porc;
        string[,,] nombreest;
        string[] materia;
        string val1;
        string val2;
        public string aux;
        public bool salir;
        public void captura()
        {
            //Inserción y validación de la cantidad de materias
            Console.Write("Ingrese la cantidad de materias" + "\r\n" + "Debe ser minimo 2" + "\r\n");

            do
            {
                val1 = Console.ReadLine();
                if (String.IsNullOrEmpty(val1))
                {
                    Console.Write("El campo no puede ser vacio " + "\r\n");
                }
                else
                {
                    mg1 = int.Parse(val1);
                    if (mg1 < 2)
                    {
                        Console.Write("Ingresó un numero no valido, debe tener minimo 2 " + "\r\n");
                    }
                }
            } while (mg1 < 2 || String.IsNullOrEmpty(val1));


            string auxx = "l";
            porc = new int[mg1, 3];


            for (i = 0; i < mg1; i++)
            {
                if (String.IsNullOrEmpty(auxx))
                {
                    Console.Write("El campo no puede ser vacio" + "\r\n");
                }
                else
                {
                    materia = new String[mg1];

                    // insercion  validacion del nombre de la materia
                    for (i = 0; i < mg1; i++)
                    {
                        do
                        {
                            Console.Write("Ingrese el nombre de la materia  " + (i + 1) + " ");
                            aux = Console.ReadLine();
                            materia[i] = aux;
                            if (String.IsNullOrEmpty(aux))
                            {
                                Console.Write("El campo no puede ser vacio" + "\r\n");
                            }
                        } while (String.IsNullOrEmpty(aux));
                    }
                    salir = false;
                    // insercin y validacion de porcentajes de las materias
                    for (j = 0; j < mg1; j++)
                    {
                        do
                        {
                            Console.Write("Ingrese el primer porcentaje de la materia " + (materia[j]) + " ");
                            aux = Convert.ToString(Console.ReadLine());
                            if (String.IsNullOrEmpty(aux))
                            {
                                Console.Write("El campo no puede ser vacio" + "\r\n");
                            }
                            else
                            {
                                if (int.Parse(aux) <= 90)
                                {
                                    porc[j, 0] = Convert.ToInt32(aux);
                                    salir = true;
                                }
                                else
                                {
                                    Console.WriteLine("el valor ingresado no es valido, ingrese nuevamente porfavor");
                                    salir = false;
                                }
                            }
                        } while (salir != true);
                        int valant = porc[j, 0];
                        salir = false;
                        do
                        {
                            Console.Write("Ingrese el segundo porcentaje de la materia " + (materia[j]) + " ");
                            aux = Convert.ToString(Console.ReadLine());
                            if (String.IsNullOrEmpty(aux))
                            {
                                Console.Write("El campo no puede ser vacio" + "\r\n");
                            }
                            else
                            {
                                if ((int.Parse(aux) + valant) <= 99)
                                {
                                    porc[j, 1] = Convert.ToInt32(aux);
                                    salir = true;
                                }
                                else
                                {
                                    Console.WriteLine("el valor ingresado no es valido, ingrese nuevamente porfavor");
                                    salir = false;
                                }
                            }
                        } while (salir != true);
                        int valfin = porc[j, 0] + porc[j, 1];
                        salir = false;
                        do
                        {
                            Console.Write("Ingrese el tercer porcentaje de la materia " + (materia[j]) + " ");
                            aux = Convert.ToString(Console.ReadLine());
                            if (String.IsNullOrEmpty(aux))
                            {
                                Console.Write("El campo no puede ser vacio" + "\r\n");
                            }
                            else
                            {
                                if ((int.Parse(aux) + valfin) == 100)
                                {
                                    porc[j, 2] = Convert.ToInt32(aux);
                                    salir = true;
                                }
                                else
                                {
                                    Console.WriteLine("el valor ingresado no es valido si desea reasignarlos valores a esta porfavor ingrese 0");
                                    salir = false;
                                }
                                if (int.Parse(aux) == 0)
                                {
                                    salir = true;
                                    j = j - 1;
                                }
                            }
                        } while (salir != true);
                    }

                    // insercioòn y validacion de la cantidad de estudiante por materia

                    Console.WriteLine("Ingrese la cantidad de estudiantes ( minimo 2 (prueba))");
                    do
                    {
                        val2 = Console.ReadLine();
                        if (string.IsNullOrEmpty(val2))
                        {
                            Console.Write("Por favor ingrese el numero de estudiantes " + "\r\n");
                        }
                        else
                        {
                            mg2 = Convert.ToInt32(val2);
                            if (mg2 < 2)
                            {
                                Console.Write("Ingresó un numero no valido, debe tener minimo 2(prueba) " + "\r\n");
                            }
                        }
                    } while (string.IsNullOrEmpty(val2) || mg2 < 2);
                    {
                        principal = new int[mg1, mg2, 3];
                        String[] nomest = new string[mg2];
                        nombreest = new String[mg1, mg2, 1];
                        for (int h = 0; h < mg1; h++)
                        {
                            for (int k = 0; k < mg2; k++)
                            {
                                // insercion y validacion del nombre del estudiante
                                Console.WriteLine("Ingrese el nombre del estudiante  " + (k + 1) + " ");
                                string aux1 = Console.ReadLine();
                                if (String.IsNullOrEmpty(aux1))
                                {
                                    Console.Write("El campo no puede ser vacio" + "\r\n");
                                }
                                else
                                {
                                    nombreest[h, k, 0] = aux1;
                                    string aux2;

                                    int b = 0;
                                    for (int p = 0; p < 3; p++)
                                    {
                                        do
                                        {
                                            // insercion y validacion de la nota de cada estudiante
                                            Console.WriteLine("Ingrese la  nota");
                                            aux2 = Convert.ToString(Console.ReadLine());

                                            if (String.IsNullOrEmpty(aux2))
                                            {
                                                Console.Write("El campo no puede ser vacio " + "\r\n");
                                            }
                                            else
                                            {
                                                b = int.Parse(aux2);

                                                if ((b > 5 || b < 1))
                                                {
                                                    Console.Write("las notas debe ser de 1 a 5  ");
                                                }

                                                else
                                                {
                                                    principal[h, k, p] = int.Parse(aux2);
                                                }
                                            }
                                        } while (String.IsNullOrEmpty(aux2) || (b > 5 || b < 1));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            def = new double[mg1, mg2, 1];

            for (int i = 0; i < mg1; i++)
            {
                for (int j = 0; j < mg2; j++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        // calculo de la difinitiva de cada estudiante
                        def[i, j, 0] = def[i, j, 0] + ((principal[i, j, m] * porc[i, m]) / 5);
                    }
                }
            }
            Console.Clear();
            // insercion y imprsion de el promedio por materia
            double auxac = 0;
            for (int a = 0; a < mg1; a++)
            {
                for (int b = 0; b < mg2; b++)
                {

                    auxac = auxac + ((def[a, b, 0] * 5) / 100);//  acumulador 

                }
                Console.WriteLine(" promedio de " + materia[a] + " es de :  " + auxac);
                auxac = 0;
            }

            ///materias
            Console.WriteLine("lista de materias : ");
            for (int h = 0; h < materia.Length; h++)
            {

                Console.WriteLine(" " + materia[h] + " ");
            }
            // nombre de de estudiantes 
            Console.Write("listado de estudiantes : ");
            for (int j = 0; j < mg1; j++)
            {
                Console.WriteLine("\r\n" + materia[j] + " ");
                for (int k = 0; k < mg2; k++)
                {
                    Console.WriteLine(nombreest[j, k, 0]);
                }

            }

            //mostar estudiante materia y nota def
            Console.WriteLine("Lista de notas con su correspondiente alumno, materia y nota final  : ");
            for (int j = 0; j < mg1; j++)
            {

                for (int k = 0; k < mg2; k++)
                {
                    Console.WriteLine("materia : " + materia[j] + " alumno : " + nombreest[j, k, 0] + " nota definitiva  : " + ((def[j, k, 0] * 5) / 100));
                }
            }
        }
    }
}