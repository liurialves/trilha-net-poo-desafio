namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
         public Nokia (string numero, string modelo, string mei, int memoria)
         : base(numero, modelo, mei, memoria)
         {

         }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string Facebook)
        {
            Console.WriteLine($"Instalando o aplicativo {Facebook} no Nokia");
        }


    }
    
}