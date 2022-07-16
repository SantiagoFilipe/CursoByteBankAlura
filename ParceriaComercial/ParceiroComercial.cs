namespace CursoByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string Senha)
        {
            return this.Senha == Senha;
        }
    }
}
