using System;
namespace Aula23Listas
{
    public class Cartao
    {
        public string Titular { get; set; }
        public float Numero { get; set; }
        public string Bandeira { get; set; }
        public DateTime vencimento { get; set; }
        public int cvv { get; set; }

        public Cartao(string titular_, float numero_, string bandeira_, DateTime vencimento_, int cvv_){
            this.Titular = titular_;
            this.Numero = numero_;
            this.Bandeira = bandeira_;
            this.Vencimento = vencimento_;
            this.cvv = cvv_;

        }
    }
}