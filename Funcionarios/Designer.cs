namespace CursoByteBank
{ 
    class Designer: Funcionario
    {
        public Designer (string CPF):base(CPF, 3000)
        {
            System.Console.WriteLine("Criando um Designer");
        }
        public override double Bonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;

        }
    }
}
