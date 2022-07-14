namespace CursoByteBank
{
    public class Funcionario
    {
        //0 - funcionário
        //1 - diretor
        //2 -designer
        //N - ...
        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao()
        {
            return Salario * 0.10;
        }
    }
}
