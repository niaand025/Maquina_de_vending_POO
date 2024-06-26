﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Vending
{
    internal class MaterialPrecioso : Producto
    {
        public string Material { get; set; }
        public double Peso { get; set; }

        public MaterialPrecioso(int id, string nombre, int unidades, float precioUnidad, string descripcion, string material, double peso)
        : base(id, nombre, unidades, precioUnidad, descripcion)
        {
            this.Material = material;
            this.Peso = peso;
        }
        public MaterialPrecioso(int id) : base(id) { }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {PrecioUnidad}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Unidades disponibles: {Unidades}");
            Console.WriteLine($"Tipo de material: {Material}");
            Console.WriteLine($"Peso: {Peso}");
        }
        public override void SolicitarInformación()
        {
            base.SolicitarInformación();
            Console.Write("Material: ");
            this.Material = Console.ReadLine();
            Console.Write("Peso: ");
            this.Peso = double.Parse(Console.ReadLine());
        }
    }
}
