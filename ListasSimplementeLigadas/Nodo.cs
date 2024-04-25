﻿namespace ListasSimplementeLigadas
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo Enlace { get; set; }

        public Nodo(string valor = "", Nodo enlace = null)
        {
            Valor = valor;
            Enlace = enlace;
        }
    }
}
