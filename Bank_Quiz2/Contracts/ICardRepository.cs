using Bank_Quiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Quiz2.Contracts
{
    public interface ICardRepository
    {
        void Create(Card carrd);
        List<Card> GetAll();
        void Update(string cardNumber, Card card);
        void Delete(string cardNumber);
        Card Get(string cardNumber);
    }
}
