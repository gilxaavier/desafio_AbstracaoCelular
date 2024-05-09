namespace DesafioPOO.Models
{
     public class Iphone : Smartphone
    {
         public Iphone(string numero) : base(numero)
        {

        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
            Console.WriteLine($"{nomeApp} instalado.");

        }
    }
}