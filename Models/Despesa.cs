using System;

namespace Mobills.Models
{
    public class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime data { get; set; }
        public bool Pago { get; set; }
    }
}