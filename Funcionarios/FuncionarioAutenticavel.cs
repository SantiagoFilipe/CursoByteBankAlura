namespace CursoByteBank
{ 
     public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
     {
        protected FuncionarioAutenticavel(string CPF, double Salario): base(CPF, Salario)
        {
            
        }
        public string Senha{ get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
     }
}
