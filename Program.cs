using CursoByteBank.Utilitarios;



namespace CursoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Designer pedro = new Designer("66599948254");
            pedro.Nome = "Pedro";

            Desenvolvedor Jorge = new Desenvolvedor("5646841684");
            Jorge.Nome = "Jorge";

            Diretor paula = new Diretor("655888449612");
            paula.Nome = "Paula";

            Auxiliar igor = new Auxiliar("316468413631");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("26143641134836");
            camila.Nome = "Camila";

            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                gerenciador.Registrar(pedro);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(igor);
                gerenciador.Registrar(camila);
                gerenciador.Registrar(Jorge);

                System.Console.WriteLine("Total de Bonificação: " + gerenciador.RetornarBonificacao());

            }

            CalcularBonificacao();
        }
    }
}