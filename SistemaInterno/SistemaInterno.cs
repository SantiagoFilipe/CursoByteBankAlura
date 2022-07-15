namespace CursoByteBank
{
    public class SistemaInterno
    {
        public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado == true)
            {
                System.Console.WriteLine("Bem vindo ao Sistema");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta");
                return false;
            }
        }       
        public bool Logar(GerenteDeContas funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                System.Console.WriteLine("Bem vindo ao Sistema");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta");
                return false;
            }

        }
    }
}
