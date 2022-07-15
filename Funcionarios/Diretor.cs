namespace CursoByteBank
{
    public class Diretor: Funcionario
    {
        public Diretor(string CPF, double Salario): base (CPF, Salario)
        {
            System.Console.WriteLine("Criando um Diretor");
            

        }
        public override double Bonificacao()
        { 
            return Salario + base.Bonificacao();
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;

        }
    }
}
