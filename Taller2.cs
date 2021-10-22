using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatos
{

    class Program
    {
        /* Declaración de estructuras*/
        public string[] nombre;
        public DateTime[] fechaNaci;
        public int mv;
        public int J;
        public int I;
        public double[] edad;
        public int opalumno;
        public int i;
        string temp;
        string fechaAct;
        public DateTime auxfecha;
        public int rv;
        public int calumno;
        DateTime dt = DateTime.Now;

        public static void Main(string[] args)
        {
            Program pv = new Program();
            pv.cargarDatos();
            Console.ReadKey();
        }

        //Metodo de datos
        public void cargarDatos()
        {
            fechaAct = dt.ToString("yyyy/MM/dd");
            mv = 0;
            opalumno = 0;
            i = 0;

            //Captura y Valida magnitud
            do
            {
                Console.Write("Ingrese la cantidad de estudiantes (debe ser minimo 1)");
                mv = int.Parse(Console.ReadLine());

                if (mv <= 0)
                {
                    Console.WriteLine("Cantidad incorrecta, vuelva y digite");
                }

            } while (mv <= 0);

            // Asignación de cantidad
            nombre = new string[mv];
            fechaNaci = new DateTime[mv];
            opalumno = new int();
            edad = new double[mv];
            rv = new int();
            calumno = new int();

            for (i = 0; i < mv; i++)
            {
                //Captura y valida de nombres
                do
                {
                    Console.Write(("Ingrese el nombre del estudiante ") + (i + 1) + " : " + "   ");
                    nombre[i] = Console.ReadLine();

                    if (String.IsNullOrEmpty(nombre[i]))
                    {
                        Console.WriteLine("Ingrese un nombre valido");
                    }
                } while (String.IsNullOrEmpty(nombre[i]));

                // Captura y validación de la fecha


                Console.WriteLine("ingrese fecha de nacimiento (dd/mm/yy) del estudiante" + (i + 1) + ":");
                do
                {
                    fechaNaci[i] = Convert.ToDateTime(Console.ReadLine()).Date;
                    if (String.IsNullOrEmpty(fechaNaci[i].ToString()))
                    {
                        Console.WriteLine("Debe ingresar una fecha de nacimiento");
                    }
                    else
                    {
                        if (DateTime.Compare(fechaNaci[i], DateTime.Now.Date) >= 0)
                        {
                            Console.WriteLine("Fecha no valida, no existe aún, ingrese de nuevo la fecha");
                        }
                    }
                } while (DateTime.Compare(fechaNaci[i], DateTime.Now.Date) >= 0);
            }

            // Calculo de la edad
            for (i = 0; i < mv; i++)
            {
                edad[i] = DateTime.Now.Year - fechaNaci[i].Year;
                edad[i] = Math.Round(edad[i] + (DateTime.Now.Year - fechaNaci[i].Year) / 365.25, 2);
            }
            //copia de vectores
            string[] nombre1 = new string[calumno];
            System.Array.Copy(nombre, nombre1, calumno);


            // ordenamiento por nombre
            double aauxedad;
            for (I = 0; I < mv; I++)
                for (J = I + 1; J < mv; J++)
                    if (nombre[I].CompareTo(nombre[J]) >= 0)
                    {
                        temp = nombre[I];
                        nombre[I] = nombre[J];
                        nombre[J] = temp;
                        aauxedad = edad[I];
                        edad[I] = edad[J];
                        edad[J] = aauxedad;
                        auxfecha = fechaNaci[I];
                        fechaNaci[I] = fechaNaci[J];
                        fechaNaci[J] = auxfecha;
                    }
            Console.Clear();
            //impresión 
            Console.WriteLine("\r\n" + "Estudiantes ordenados de menor a mayor alfabeticamente.." + "\r\n");
            Console.Write("Nombre" + "\t" + "Fecha de nacimiento" + "\r\n" + "\r\n");
            //impresión de datos

            for (J = 0; J < mv; J++)
            {
                Console.Write(nombre[J] + "\t" + fechaNaci[J].ToShortDateString() + "\r\n");
            }
            // ordenamiento por edad 

            string auxom;
            for (I = 0; I < mv; I++)
                for (J = I + 1; J < mv; J++)
                    if (edad[I] > edad[J])
                    {
                        auxom = Convert.ToString(nombre[I]);
                        rv = Convert.ToInt32(edad[I]);
                        nombre[I] = nombre[J];
                        nombre[J] = auxom;
                        edad[I] = edad[J];
                        edad[J] = rv;
                        J = 0;
                        i = 0;
                    }


            Console.WriteLine("\r\n" + "Estudiantes ordenados de menor a mayor" + "\r\n");

            Console.Write("Nombre" + "\t" + "Edad" + "\r\n");

            for (int J = 0; J < mv; J++)
            {
                Console.Write(nombre[J] + "\t" + edad[J] + "\t" + "\r\n");
            }
        }
    }
}
