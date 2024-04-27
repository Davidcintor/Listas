namespace ListasDoblementeLigadas
{
    public class Nodos
    {
        //propiedades
        public string Valor { get; set; }
        public Nodos EnlaceAnterior { get; set; }
        public Nodos EnlaceSiguiente { get; set; }

        public Nodos(string valor = "", Nodos enlaceA = null, Nodos enlaceS = null)
        {
            Valor = valor;
            EnlaceAnterior = enlaceA;
            EnlaceSiguiente = enlaceS;
        }
    }
}
