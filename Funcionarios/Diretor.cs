namespace CursoByteBank
{
    public class Diretor: Funcionario
    {
        public override double Bonificacao()
        { 
            return Salario + base.Bonificacao();
        }
    }
}
