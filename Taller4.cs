using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4 {
    class Program {
        static void Main (string[] args) {
            Program pr = new Program ();
            pr.captura ();
            DateTime dat = DateTime.Now;
            Console.WriteLine ("La hora de ejecución es: {0:d} at {0:t}", dat);
            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine ("La hora de la zona es: {0}\n",
                tz.IsDaylightSavingTime (dat) ?
                tz.DaylightName : tz.StandardName);
            Console.Write ("Presione enter para salir del programa ");
            while (Console.ReadKey (true).Key != ConsoleKey.Enter);
        }
        // captura de variables y asignaciones
        int i;
        int j;
        int mg1;
        int mg2;
        int[, ] mat;
        int[] mat1;
        int[] mat2;
        int mult;
        int suma = 0;
        string ac;
        string ac1;

        public void captura () {

            //Inserción y validación de las magnitudes de la matriz
            Console.Write ("Ingrese el numero de filas de la matriz" + "\r\n" + " debe ser igual al numero de columnas" + "\r\n");
            do {
                do {
                    ac = Console.ReadLine ();
                    if (String.IsNullOrEmpty (ac)) {
                        Console.Write ("Por favor ingrese el numero" + "\r\n");
                    } else {
                        mg1 = int.Parse (ac);
                        if (mg1 <= 0) {
                            Console.Write ("El numero de filas no debe ser menor o igual a 0. Vuelva a ingresar el numero" + "\r\n");
                        } else { }
                    }
                } while (mg1 <= 0 || String.IsNullOrEmpty (ac));

                Console.Write ("Ingrese el numero de columnas de la matriz" + "\r\n" + "el numero de las columnas debe ser el mismo de las filas" + "\r\n");
                do {
                    ac = Console.ReadLine ();

                    if (String.IsNullOrEmpty (ac)) {
                        Console.Write ("Por favor ingrese el numero" + "\r\n");
                    } else {
                        mg2 = int.Parse (ac);
                        if (mg2 <= 0) {
                            Console.Write ("El numero de columnas no debe ser menor o igual a 0. Vuelva a ingresar el numero" + "\r\n");
                        }
                    }
                } while (mg2 <= 0 || String.IsNullOrEmpty (ac));
                if (mg2 != mg1) {
                    Console.Write ("El numero de filas y columnas no son iguales, vuelva a digitarlas por favor");
                }
            } while (mg2 != mg1);

            //Inserción de datos a la matriz
            mat = new int[mg1, mg2];

            for (i = 0; i < mg1; i++) {
                for (j = 0; j < mg2; j++) {
                    do {
                        Console.Write ("Ingrese el numero para la posiciòn" + "[" + i + "," + j + "]" + "(debe ser de dos digitos)" + "\r\n");
                        ac1 = Console.ReadLine ();
                        if (String.IsNullOrEmpty (ac1)) {
                            Console.Write ("No puede estar vacia, ingrese un numero" + "\r\n");
                        } else {
                            mat[i, j] = int.Parse (ac1);
                        }
                        if (mat[i, j] < 10 || mat[i, j] > 99) {
                            Console.Write ("El numero tiene que ser un numero valido y  de dos digitos" + "\r\n");
                        }
                    } while (mat[i, j] < 10 || mat[i, j] > 99);
                }
            }

            // Insercion de la diagonal principal al vector temporal
            mat1 = new int[mg1];

            for (i = 0; i < mg1; i++) {
                for (j = 0; j < mg2; j++) {
                    if (i == j) {
                        mat1[i] = mat[i, j];
                    }
                }
            }

            //Inserccion de la diagonal transpuesta al segundo vector temporal
            mat2 = new int[mg1];
            j = mg2 - 1;
            for (i = 0; i < mg1; i++) {
                mat2[i] = mat[i, j];
                j = j - 1;
            }
            
            //Calculo de la suma de los elementos de la diagonal principal
            //Calculo de la multiplicacion de los elementos de la diagonal transpuesta

            mult = 1;
            for (i = 0; i < mg1; i++) {
                suma = suma + mat1[i];
                mult = mult * mat2[i];
            }
            Console.Clear ();
            /////////////////////
            Console.Write ("Matriz de " + mg1 + "x" + mg2 + "\r\n" + "\r\n");

            // mostrar matriz completa

            for (i = 0; i < mg1; i++) {
                for (j = 0; j < mg2; j++) {
                    Console.Write (mat[i, j] + " ");
                }
                Console.WriteLine ();
            }
            //Mostrar los vectores con las diagonales
            Console.Write ("\r\n" + "vector de la " + mg1 + "  diagonal principal:" + "\r\n");
            Console.WriteLine ();

            for (i = 0; i < mg1; i++) {
                Console.Write (mat1[i] + "\r\n");
            }

            // impresiòn Suma diagonal principal
            Console.WriteLine ();
            Console.Write ("Vector de " + mg1 + " casillas con los numeros de la diagonal transpuesta:" + "\r\n");
            Console.WriteLine ();

            // Impresión de diagonal transpuesta
            for (i = 0; i < mg1; i++) {
                Console.Write (mat2[i] + "\r\n");
            }

            //Mostrar la multiplicacion de la diagonal transpuesta  y la suma de la diagonal principal

            Console.WriteLine ();
            Console.Write ("la suma de los elementos de la diagonal principal es: " + suma + "\r\n");
            Console.Write ("La multiplicacion de los elementos de la diagonal transpuesta es: " + mult + "\r\n");
            Console.WriteLine ();
            Console.WriteLine ("----------------------------------------------------------------------------------------------------------------------");
        }

    }
}