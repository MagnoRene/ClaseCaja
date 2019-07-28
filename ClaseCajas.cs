using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasecaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Caja 1====================");
            Caja caja1 = new Caja(5, 6, 7);
            caja1.MostrarDatos1();
            Console.WriteLine("====================Caja 2====================");
            Caja caja2 = new Caja(10, 6, 6, "Azul");
            caja2.MostrarDatos2();
            Console.WriteLine("====================Caja 3====================");
            Caja caja3 = new Caja(6, 10, 6, "Rojo", "Solapas");
            caja3.MostrarDatos3_4();
            Console.WriteLine("====================Caja 4====================");
            Caja caja4 = new Caja("Cafes", 6, 7, 10, "Carton", "Solapas");
            caja4.MostrarDatos3_4();
            Console.ReadKey();
        }
        public class Caja
        {
            //----------------- propiedades_------------
            public string NomEmpresa = "Los Cuates";
            public string Color { get; set; }
            public double Altura  { get; set; }
            public double Ancho { get; set; }
            public double Profundidad { get; set; }
            public string TipoMaterial { get; set; }
            public string Estructura { get; set; }
            public string LadoAbrir { get; set; }

            // ------------Constructor 1---------------
            public Caja (double altura, double ancho, double profundidad)
            {
                this.Altura = altura;
                this.Ancho = ancho;
                this.Profundidad = profundidad; ;
            }
            //------------------Constructor 2-------------------
            public Caja (double altura, double ancho, double profundidad,string color)
            {
                this.Altura = altura;
                this.Ancho = ancho;
                this.Profundidad = profundidad;
                this.Color = color;
            }
            // ----------------- Constructor 3------------------
            public Caja(double altura, double ancho, double profundidad,string color,string estructura)
            {
                this.Altura = altura;
                this.Ancho = ancho;
                this.Profundidad = profundidad;
                this.Color = color;
               
                this.Estructura = estructura;
                if (color =="Rojo" || color =="rojo")
                {
                    this.TipoMaterial = "Metal";
                    this.LadoAbrir = "No asignado";
                }
                if (color =="Cafes" || color =="cafes")
                {
                    this.TipoMaterial = "Carton";
                    this.LadoAbrir = "Se abre por arriba";
                }
            }
            // ----------------- Constructor 4------------------
            public Caja(string color,double altura,double ancho,double profundidad,string tipomaterial,string estructura)
            {
                this.Color = color;
                this.Altura = altura;
                this.Ancho = ancho;
                this.Profundidad = profundidad;
                this.TipoMaterial =tipomaterial;
                this.Estructura = estructura;
                if (tipomaterial == "Carton" || tipomaterial == "carton")
                {
                    this.LadoAbrir = "Se abre por arriba";
                }
                else
                {
                    this.LadoAbrir = "No asignado";
                }    
            }
            // ----------Metodos---------
            public void MostrarDatos1()
            {
                Console.WriteLine("Altura: " + Altura + " Ancho: " + Ancho + " Profundidad: " + Profundidad);
                Console.WriteLine();
            }
            public void MostrarDatos2()
            {
                Console.WriteLine("Altura: " + Altura + " Ancho: " + Ancho + " Profundidad: " + Profundidad+" Color: "+Color);
                Console.WriteLine();
            }
            public void MostrarDatos3_4()
            {
                Console.WriteLine("Color: " + Color + " Altura: " + Altura + " Ancho: " + Ancho + " Profundidad: " + Profundidad + " Tipo Material: " + TipoMaterial + " Estructura: " + Estructura+" Empresa: "+NomEmpresa+" Lado para abrir: "+LadoAbrir);
                Console.WriteLine();
            }
        }
    }
}
