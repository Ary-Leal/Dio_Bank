namespace dio_bank
{
    public class Conta
    {
       private TipoConta TipoConta (get; set;) 

       private double Saldo (get; set;) 

       private double Credito (get; set;) 

       private double Nome (get; set;) 

       // constructor
 
      public Conta ( TipoConta tipoConta, double saldo, double credito, string nome) {

          this.TipoConta = tipoConta;
          this.Saldo = saldo;
          this.Credito = credito;
          this.Nome = nome;
      }

    }
}