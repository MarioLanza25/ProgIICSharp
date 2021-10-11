using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = { 15, 12, 32, 67, 89, 44 };

            int[] e1;
            e1 = new[] { 3, 45, 12, 26, 67, 23 };

            int[] e2;
            e2 = new int[5];
            e2[0] = 15;
            e2[1] = 45;
            e2[2] = 23;
            e2[3] = 19;
            e2[4] = 89;
            e2[5] = 2;

            //arrays implicitos
            var datos = new[] { 15, 23, 12, 67, 78, 65 };
            var datos1 = new[] { "Juan", "Ana", "Amelia" };

            Empleados emp1 = new Empleados("Ana", 23);
            //arrays de objetos

            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 38);
            arrayEmpleados[1] = emp1;
            arrayEmpleados[2] = new Empleados("Carlos", 35);

            //Arrays de tipos o clases anonimas
        //    var personas = new[]
        //    {
        //        new (Nombre= "Juan", Edad = 10);
        //    new (Nombre= "Ana", Edad = 49);
        //    new (Nombre= "Amelia", Edad = 35);
        //};



        }

    class Empleados
    {
        private string nombre;
        private int edad;

        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return "Nombre del empleado: " + nombre +
                "Edad: " + edad;
        }
    }
}
