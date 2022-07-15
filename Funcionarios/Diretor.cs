namespace CursoByteBank
{
    public class Diretor: Funcionario
    {
        public Diretor(string CPF): base (CPF, 5000)
        {
            System.Console.WriteLine("Criando um Diretor");    
        }
        public override double Bonificacao()
        { 
            return Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
