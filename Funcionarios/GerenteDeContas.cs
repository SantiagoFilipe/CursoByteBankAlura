namespace CursoByteBank
{
    public class GerenteDeContas: Funcionario
    {
        public GerenteDeContas (string CPF):base(CPF, 4000) 
        {
            System.Console.WriteLine("Criando um Gerente");

        }
        public override double Bonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.05;

        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
