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
            paula.Senha = "548";

            Diretor mateus = new Diretor("5451434345");
            mateus.Nome = "Mateus";
            mateus.Senha = "Z48";

            Auxiliar igor = new Auxiliar("316468413631");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("26143641134836");
            camila.Nome = "Camila";
            camila.Senha = "895";

            ParceiroComercial cesar = new ParceiroComercial();
            cesar.Senha = "888";

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

            void UsarSistema()
            {
                SistemaInterno sistema = new SistemaInterno();
                sistema.Logar(paula, "548");
                sistema.Logar(camila, "4545");
                sistema.Logar(cesar, "888");
            }
            CalcularBonificacao();
            UsarSistema();
        }
    }
}