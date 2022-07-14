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
    }
}
