namespace CursoByteBank
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int totalDeFuncionarios { get; private set; }
        public Funcionario(string CPF, double Salario) 
        {
            this.CPF = CPF;
            this.Salario = Salario;
            totalDeFuncionarios++;
        }

        public abstract double Bonificacao();


        public abstract void AumentarSalario();
        
    }
}