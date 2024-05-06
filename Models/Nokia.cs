namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string ime, int memoria) 
            : base(numero, modelo, ime, memoria)
        {
            // Pode adicionar lógica adicional aqui se necessário
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}