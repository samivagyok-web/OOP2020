using System;

namespace Curs_5
{
    class ContBancar
    {
        private decimal sold;
        private string titular;
        private Guid id;

        public ContBancar()
        {
            id = Guid.NewGuid();
        }

        public void Depune(decimal money)
        {
            if (money <= 0) throw new InvalidAmountException($"Valoare depusa este negativa sau zero: {money}");
            else sold += money;
        }

        public override string ToString()
        {
            return $"Titular: {this.titular} \nID: {this.id} \nSold: {this.sold}";
        }
    }
}