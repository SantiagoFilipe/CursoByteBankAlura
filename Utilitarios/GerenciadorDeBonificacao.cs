namespace CursoByteBank.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.Bonificacao();
        }
        public double Bonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
