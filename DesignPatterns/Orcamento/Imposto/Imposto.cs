namespace DesignPatterns
{
    public abstract class Imposto
    {

         public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;

        }
        public Imposto()
        {
            this.OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento) => (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
    }

}