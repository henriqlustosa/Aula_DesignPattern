namespace DesignPatterns
{
    public interface IEstadoDaConta
    {
        void Saca(ContaBanco conta, double valor);
        void Deposita(ContaBanco conta, double valor);
    }
}