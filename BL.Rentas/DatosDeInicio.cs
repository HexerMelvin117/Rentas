﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class DatosDeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var ciudad1 = new Ciudad();
            ciudad1.Descripcion = "San Pedro Sula";
            contexto.Ciudades.Add(ciudad1);

            var ciudad2 = new Ciudad();
            ciudad2.Descripcion = "Tegucigalpa";
            contexto.Ciudades.Add(ciudad2);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Acción y Aventura";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Deportes";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Disparo";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Educativos";
            contexto.Categorias.Add(categoria4);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Accesorios";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Consolas";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Video Juegos";
            contexto.Tipos.Add(tipo3);


            base.Seed(contexto);
        }
    }
}
