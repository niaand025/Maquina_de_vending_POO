﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Vending
{
    internal abstract class Producto
    {
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public double PrecioUnidad { get; set; }
        public string Descripcion { get; set; }

        public Producto(string nombre, int unidades, double precioUnidad, string descripcion)
        {
            this.Nombre = nombre;
            this.Unidades = unidades;
            this.PrecioUnidad = precioUnidad;
            this.Descripcion = descripcion;
        }
        public abstract void ToFile();
    }
}
