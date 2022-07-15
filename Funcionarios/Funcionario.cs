namespace CursoByteBank
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public virtual double Bonificacao()
        {
            return Salario * 0.10;
        }

        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string CPF, double Salario) 
        {
            this.CPF = CPF;
            this.Salario = Salario;
            System.Console.WriteLine("Criando Funcionário");
            totalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;

        }
    }
}