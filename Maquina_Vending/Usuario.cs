﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Vending
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Nombre { get; set; }
        public string Ape1 { get; set; }
        public string Ape2 { get; set; }
        private string Password { get; set; }

        public Usuario(int id, string nickName, string nombre, string ape1, string ape2, string password)
        {
            Id = id;
            NickName = nickName;
            Nombre = nombre;
            Ape1 = ape1;
            Ape2 = ape2;
            Password = password;            
        }
        public Usuario(string nombre, string ape1, string ape2)
        {
            this.Nombre = nombre;
            this.Ape1 = ape1;
            this.Ape2 = ape2;
        }
        public Usuario() { }
        public string GetRealName()
        {
            return $"{Nombre} {Ape1} {Ape2}";
        }
        public bool Login(string nickname, string password)
        {
            // Verificar si el nickname y la contraseña coinciden con los datos del usuario
            if (NickName == nickname && Password == password)
            {
                Console.WriteLine("Inicio de sesión exitoso.");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos. Inicio de sesión fallido.");
                return false;
            }
        }
        public void ToFile()
        {
            //Abrimos el archivo en modo append, para no sobreescribir los datos existente
            StreamWriter sw = new StreamWriter("usuarios.txt", true);
            sw.WriteLine($"{Id}|{NickName}|{Nombre}|{Ape1}|{Ape2}|{Password}");
            sw.Close();
        }
        public abstract void Menu();
        public abstract void Salir();
    }
}