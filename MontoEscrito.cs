using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontoEscrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Program cv = new Program();
            cv.ToString();
            DateTime dat = DateTime.Now;

            TimeZoneInfo tz = TimeZoneInfo.Local;
            string nume = "";
            string nom = "";
            string nombank = "";
            do
            { // Captura del nombre de la persona
                Console.WriteLine("Ingrese el nombre de la persona ");
                nom = Console.ReadLine();
                // validación de si está vació
                if (String.IsNullOrEmpty(nom))
                {
                    Console.Write("El campo no puede ser vacio" + "\r\n");

                }
            } while (String.IsNullOrEmpty(nom));

            bool valiop = false;
            bool sal = false;
            do
            {
                // Captura de la cantidad
                do
                {
                    Console.WriteLine("ingrese monto menor a  9 digitos ");
                    try
                    {
                        nume = Console.ReadLine();
                        double j = double.Parse(nume);
                        int en = (int.Parse(nume.Split('.')[0]));
                        valiop = true;
                    }
                    catch (Exception ex)
                    {
                        valiop = false;
                        Console.WriteLine("Solo puede ingresar menor a 9 digitos ");
                    }
                } while (valiop == false);
                int puntos = 0;
                sal = false;
                for (int k = 0; k < nume.Length; k++)
                { // si hay un punto
                    if (nume.Substring(k, 1) == ".")
                    {
                        puntos++;
                    }
                }
                if (puntos > 1)
                {// si hay mas de dos  puntos valide
                    Console.WriteLine("numero no valido");
                    puntos = 0;
                    sal = false;
                }
                else { sal = true; }
                //  No puede ser vacio
                if (String.IsNullOrEmpty(nume))
                {
                    Console.Write("El campo no puede ser vacio" + "\r\n");

                }
                //  Validación de que no puede exceder los 9 digitos
                else if (Convert.ToDouble(nume) > 10000000000)
                {
                   // Console.Write("Ingrese un valor menor a 9 digitos" + "\r\n");

                }
                //  validacion de que no puede ser negativo
                else if (Convert.ToDouble(nume) < 0)
                {
                    Console.Write("Ingrese un valor positivo" + "\r\n");

                }

            } while (String.IsNullOrEmpty(nume) || Convert.ToDouble(nume) > 99999999999 || Convert.ToDouble(nume) < 0 || sal == false);

            do
            {    // captura del nombre del banco
                Console.WriteLine("Ingrese el nombre del banco ");
                nombank = Console.ReadLine();
                if (String.IsNullOrEmpty(nombank))
                {
                    Console.Write("El campo no puede ser vacio" + "\r\n");

                }

            } while (String.IsNullOrEmpty(nombank));
            Console.Clear();
            bool isdec = false;
            //Recorre la cadena en busca de puntos, si tiene puntos es decimal, si no, es entero.
            for (int j = 0; j < nume.Length; j++)
            {
                if (nume.Substring(j, 1) == ".")
                {
                    isdec = true;
                }
            }
            float dec = 0;

            //Si es decimal coja la parte decimal y guardela en la variable acá guarda despues del punto los numeros y los guarda en dec
            int ent = (int.Parse(nume.Split('.')[0]));
            if (isdec == true)
            {
                dec = (float.Parse("0" + nume.Split('.')[1]));
            }
            else
            {
                dec = 0;
            } //impresion
            Console.Write(" | Banco  : " + nombank + " |" + "\r\n");
            Console.WriteLine(" | Fecha : {0:d}", dat + "                  Valor  : " + nume + " |");
            Console.Write(" | Cliente : " + nom + "\r\n" + " | Cheque por el valor de : $ " + cv.enletras(ent.ToString()) +" Pesos" + " con " + dec + " centavos   " + "|" + "\r\n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Presione enter para salir del programa ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

        }




        public string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }
            // calcula decimales
            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;


        } // Proceso de conversion a letras
        public string toText(double value)
        {

            string Num2 = "";
            value = Math.Truncate(value);
            if (value == 0) Num2 = "Cero";
            else if (value == 1) Num2 = "Uno";
            else if (value == 2) Num2 = "Dos";
            else if (value == 3) Num2 = "Tres";
            else if (value == 4) Num2 = "Cuatro";
            else if (value == 5) Num2 = "Cinco";
            else if (value == 6) Num2 = "Seis";
            else if (value == 7) Num2 = "Siete";
            else if (value == 8) Num2 = "Ocho";
            else if (value == 9) Num2 = "Nueve";
            else if (value == 10) Num2 = "Diez";
            else if (value == 11) Num2 = "Once";
            else if (value == 12) Num2 = "Doce";
            else if (value == 13) Num2 = "Trece";
            else if (value == 14) Num2 = "Catorce";
            else if (value == 15) Num2 = "Quince";
            else if (value < 20) Num2 = "Dieci" + toText(value - 10);
            else if (value == 20) Num2 = "Veinte";
            else if (value == 21) Num2 = "Veintiun";
            else if (value >21 ||value < 30) Num2 = "Veinti" + toText(value - 20);
            else if (value == 30) Num2 = "Treinta";
            else if (value == 40) Num2 = "Cuarenta";
            else if (value == 50) Num2 = "Cincuenta";
            else if (value == 60) Num2 = "Sesenta";
            else if (value == 70) Num2 = "Setenta";
            else if (value == 80) Num2 = "Ochenta";
            else if (value == 90) Num2 = "Noventa";
            else if (value < 100) Num2 = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2 = "Cien";
            else if (value < 200) Num2 = "Ciento " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2 = toText(Math.Truncate(value / 100)) + "Cientos";
            else if (value == 500) Num2 = "Quinientos";
            else if (value == 700) Num2 = "Setecientos";
            else if (value == 900) Num2 = "Novecientos";
            else if (value < 1000) Num2 = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2 = "Mil";
            else if (value < 2000) Num2 = "Mil " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2 = toText(Math.Truncate(value / 1000)) + " Mil";
                if ((value % 1000) > 0) Num2 = Num2 + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2 = "Un Millon";
            else if (value < 2000000) Num2 = "Un Millon " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2 = toText(Math.Truncate(value / 1000000)) + " Millones ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2 = Num2 + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2 = "Un Billon";
            else if (value < 2000000000000) Num2 = "Un Billon " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2 = toText(Math.Truncate(value / 1000000000000)) + " Billones";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2 = Num2 + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2;

        }



    }
}
