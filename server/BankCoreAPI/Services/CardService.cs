using BankCoreAPI.DTOs.Card;
using BankCoreAPI.Interfaces;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Services
{
    public class CardService : ICardService
    {
        public Task<CardDTO> ActivateCardAsync(CardCheckerDTO card)
        {
            throw new NotImplementedException();
        }

        public Task<CardDTO> CreateCardAsync(CardCreaterDTO card)
        {
            throw new NotImplementedException();
        }

        public Task<DepositResponse> DepositMoneyCardAsync(CardCheckerDTO card)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CardDTO>> GetCardsByUserIdAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<DepositResponse> TransferMoneyAsync(CardCheckerDTO cardSender, string numberReceiver, double amount)
        {
            throw new NotImplementedException();
        }
    }
}
