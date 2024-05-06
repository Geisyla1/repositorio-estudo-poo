namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string ime, int memoria) 
            : base(numero, modelo, ime, memoria)
        {
            // Pode adicionar lógica adicional aqui se necessário
        }

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Apple...");
        }
    }
}