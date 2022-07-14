namespace CursoByteBank
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao()
        {
            return Salario * 0.10;
        }

        public static int totalDeFuncionarios { get; private set; }

        public Funcionario() 
        {
            System.Console.WriteLine("Criando Funcionário");
            totalDeFuncionarios++;
        }
    }
}