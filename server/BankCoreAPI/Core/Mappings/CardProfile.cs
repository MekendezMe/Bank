using AutoMapper;
using BankCoreAPI.Core.Models.Cards;
using BankCoreAPI.DTOs.Card;

namespace BankCoreAPI.Core.Mappings
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Card, CardDTO>();
            CreateMap<CardDTO, Card>();
            CreateMap<CardTransaction, CardTransactionDTO>();
            CreateMap<CardTransactionDTO, CardTransaction>();
        }
    }
}
