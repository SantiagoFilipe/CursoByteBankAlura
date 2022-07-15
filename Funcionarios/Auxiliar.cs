namespace CursoByteBank
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar (string CPF): base(CPF, 2000)
        {
            System.Console.WriteLine("Criando um Auxiliar");

        }
        public override double Bonificacao()
        {
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.2;

        }
    }
}
