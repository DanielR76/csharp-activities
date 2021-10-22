using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz {

    class Matriz {
        static void Main (string[] args) {
            Matriz ma = new Matriz ();
            ma.Ingresar ();
            Console.ReadKey ();
        }

        //Declaraciòn de variables
        private int[, ] mat;
        public int mv1;
        public int mv2;
        public int i;
        public int j;
        public int acumuladorFilas;
        public int acumuladorColumnas;
        public int acumuladorMatriz;
        public int sumF;
        public int sumC;
        public int sumT;

        public void Ingresar () {
            mv1 = 0;
            mv2 = 0;
            acumuladorFilas = 0;
            acumuladorColumnas = 0;
            acumuladorMatriz = 0;

            //Inserción  y validaciòn de las filas (magnitud)
            do {
                Console.Write ("Ingrese la cantidad de filas de la Matriz (minimo 1):");
                mv1 = int.Parse (Console.ReadLine ());
                if (mv1 <= 0) {
                    Console.WriteLine ("Numero NO valido!!");
                }
            } while (mv1 <= 0);

            //Inserción  y validaciòn de las columnas (magnitud)
            do {
                Console.Write ("Ingrese la cantidad de columnas de la Matriz (minimo 1):");
                mv2 = int.Parse (Console.ReadLine ());
                if (mv2 <= 0) {
                    Console.WriteLine ("Numero NO valido!!");
                }

            } while (mv2 <= 0);

            //Instancia de la matriz
            mat = new int[mv1, mv2];

            //Inserciòn y validaciòn de las celdas
            for (i = 0; i < mv1; i++) {
                for (j = 0; j < mv2; j++) {
                    do {
                        Console.Write ("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                        mat[i, j] = int.Parse (Console.ReadLine ());
                        if (mat[i, j] >= 10 || mat[i, j] < 0) {
                            Console.WriteLine ("\t\r" + "Numero NO valido!!" + "\t\r");
                        }
                    } while (mat[i, j] >= 10 || mat[i, j] < 0);
                }
            }

            //Liempieza de pantalla
            //Console.Clear();

            for (i = 0; i < mv1; i++) {
                for (j = 0; j < mv2; j++) {
                    Console.Write (mat[i, j] + " ");
                }
                Console.WriteLine ();
            }

            //Impresion sumatoria filas 
            sumF = 0;
            for (int i = 0; i < mat.GetLength (0); i++) {

                for (int j = 0; j < mat.GetLength (0); j++) {
                    sumF = sumF + mat[i, j];
                }
                Console.WriteLine ("sumatoria de la Fila {0} es {1}", i + 1, sumF);
                //sumF = 0;
            }

            //Impresion sumatoria columnas
            sumC = 0;
            for (int i = 0; i < mat.GetLength (0); i++) {
                for (int j = 0; j < mat.GetLength (0); j++) {
                    sumC = sumC + mat[j, i];
                }
                Console.WriteLine ("sumatoria de la Columna {0} es {1}", i + 1, sumC);
                //sumC = 0;
            }

            //Impresion total de la Matriz
            /*int mv3 = 0;
            int pro = 0;
            sumT = sumF + sumC;
            mv3=mv1 + mv2;
            pro = sumT / mv3;
            Console.WriteLine("Suma total es:" + sumT);
            Console.WriteLine("Suma total es:" + pro);
            */

            //Impresion total de la Matriz
            double resul = 0;
            for (i = 0; i < mv1; i++) {
                for (j = 0; j < mv2; j++) {
                    acumuladorFilas = acumuladorFilas + mat[i, j];
                    //    acumuladorColumnas = acumuladorColumnas + mat[j, i];
                }
                resul = Convert.ToDouble (acumuladorFilas / mv1);
                Console.WriteLine ("El promedio de la fila  " + (i + 1) + " es de " + (resul));
                acumuladorFilas = 0;

            }
            double resul2 = 0;
            for (i = 0; i < mv1; i++) {

                for (j = 0; j < mv2; j++) {
                    acumuladorColumnas = acumuladorColumnas + mat[i, j];
                    //    acumuladorColumnas = acumuladorColumnas + mat[j, i];
                }
                resul2 = Convert.ToDouble (acumuladorColumnas / mv1);
                Console.WriteLine ("El promedio de la columna " + (i + 1) + "es de " + (acumuladorColumnas / mv2));
                acumuladorColumnas = 0;
            }

            Console.WriteLine ("El promedio total de la matriz es" + (acumuladorMatriz / (mv1 * mv2)));
            Console.WriteLine ("El  total de la matriz es " + (acumuladorMatriz));

        }
    }
}