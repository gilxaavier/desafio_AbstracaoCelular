namespace DesafioPOO.Models
{
     public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no nokia.....");
            Console.WriteLine($"{nomeApp} instalado.");
        }
    }
}