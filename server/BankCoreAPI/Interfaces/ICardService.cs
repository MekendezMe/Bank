using BankCoreAPI.DTOs.Card;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Interfaces
{
    public interface ICardService
    {
        Task<CardDTO> CreateCardAsync(CardCreaterDTO card);

        Task<CardDTO> ActivateCardAsync(CardCheckerDTO card);

        Task<IEnumerable<CardDTO>> GetCardsByUserIdAsync(long userId);

        Task<DepositResponse> DepositMoneyCardAsync(CardCheckerDTO card);

        Task<DepositResponse> TransferMoneyAsync(CardCheckerDTO cardSender, string numberReceiver, double amount);
    }
}
