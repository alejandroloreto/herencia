using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herencias
{
    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Edad:" + Edad);
        }
    }}