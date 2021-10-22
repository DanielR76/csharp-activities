using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1 {
    class Program {
        /* Declaración de estructuras*/
        private string[] Nom;
        private double[] Nota1;
        public double[] Nota2;
        public double[] Nota3;
        public double[] Def;
        public double Prom;
        public double Nalta;
        public double Nbaja;
        public double Adef;
        int I;

        public static void Main (string[] args) {
            Program pv = new Program ();
            pv.cargarDatos ();
            Console.ReadKey ();
        }

        //Metodo de datos
        public void cargarDatos () {
            Nom = new string[3];
            Nota1 = new double[3];
            Nota2 = new double[3];
            Nota3 = new double[3];
            Def = new double[3];
            Prom = 0;
            Adef = 0;
            Nbaja = 5;
            Nalta = 0;
            I = 0;

            //Lectura de datos
            {
                Console.WriteLine ("CAPTURA DE DATOS");
                for (int I = 0; I < 3; I++) {
                    do {
                        Console.Write (("Ingrese el nombre del estudiante ") + (I + 1) + " : " + "   ");
                        Nom[I] = Console.ReadLine ();

                        if (String.IsNullOrEmpty (Nom[I])) {
                            Console.WriteLine ("Ingrese un nombre valido");
                        }
                    } while (String.IsNullOrEmpty (Nom[I]));

                    do {
                        Console.WriteLine ("Ingrese nota de primer corte (entre 0 y 5)");
                        Nota1[I] = float.Parse (Console.ReadLine ());

                        if (Nota1[I] < 0 || Nota1[I] > 5) {
                            Console.WriteLine ("Nota ingresada no valida");
                        }
                    }
                    while (Nota1[I] < 0 || Nota1[I] > 5);

                    do {
                        Console.WriteLine ("Ingrese nota de segundo corte (entre 0 y 5)");
                        Nota2[I] = float.Parse (Console.ReadLine ());

                        if (Nota2[I] < 0 || Nota2[I] > 5) {
                            Console.WriteLine ("Nota ingresada no valida");
                        }
                    }
                    while (Nota2[I] < 0 || Nota2[I] > 5);

                    do {
                        Console.WriteLine ("Ingrese nota de tercer corte (entre 0 y 5)");
                        Nota3[I] = float.Parse (Console.ReadLine ());

                        if (Nota3[I] < 0 || Nota3[I] > 5) {
                            Console.WriteLine ("Nota ingresada no valida");
                        }
                    }
                    while (Nota3[I] < 0 || Nota3[I] > 5);

                    // Operaciones para definitiva del estudiante y promedio
                    Def[I] = (Nota1[I] * 20 + Nota2[I] * 35 + Nota3[I] * 45) / 100;
                    Adef = Adef + Def[I];
                    Prom = Adef / 3;
                }

            }
            // Operación para hacer la nota mas alta y baja
            for (int I = 0; I < 3; I++) {
                if (Def[I] > Nalta) {
                    Nalta = Def[I];
                }
                if (Def[I] < Nbaja) {
                    Nbaja = Def[I];
                }
            }

            //Impresión de notas y definitiva del curso vacacional
            Console.WriteLine ("Definitivas curso vacacional: " + "\r\n");
            Console.WriteLine ("Nombre  1er corte  2do corte 3er corte Definitiva vacional" + "\r\n");
            for (int I = 0; I < 3; I++) {
                Console.WriteLine (Nom[I] + "\t" + Nota1[I] + "\t" + Nota2[I] + "\t" + Nota3[I] + "\t" + Def[I] + "\t");
            }

            //Validación de aprobación en general del curso
            if (Prom >= 3) {
                Console.WriteLine ("Felicitaciones el curso tuvo un promedio  mayor a 3" + "\r\n");
            }
            Console.Write ("Promedio del curso:  " + string.Format ("{0:C1}", Prom) + "\r\n\n");
            Console.Write ("Definitiva de la nota más alta del curso :  " + string.Format ("{0:C1}", Nalta) + "\r\n\n");
            Console.Write ("Definitiva más baja del curso:  " + string.Format ("{0:C1}", Nbaja) + "\r\n\n");
        }

    }

}