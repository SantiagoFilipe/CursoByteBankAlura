namespace CursoByteBank
{
    public class Desenvolvedor: Funcionario
    {
        public Desenvolvedor(string CPF):base(CPF, 3500)
        {
            System.Console.WriteLine("Criando um novo Desenvolvedor");
        }
        public override double Bonificacao()
        {
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;

        }

    }

}
