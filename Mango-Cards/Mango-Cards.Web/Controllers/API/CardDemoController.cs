using AutoMapper;
using Mango_Cards.Library.Models;
using Mango_Cards.Library.Services;
using Mango_Cards.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mango_Cards.Web.Controllers.API
{
    public class CardDemoController : BaseApiController
    {
        private readonly ICardDemoService _cardDemoService;
        public CardDemoController(ICardDemoService cardDemoService)
        {
            _cardDemoService = cardDemoService;
        }
        public object Get()
        {
            Mapper.Reset();
            Mapper.CreateMap<CardType, CardTypeModel>().ForMember(n => n.Parent, opt => opt.MapFrom(src => src.Parent));
            Mapper.CreateMap<CardDemo, CardDemoModel>();
            return _cardDemoService.GetCardDemos().Select(Mapper.Map<CardDemo, CardDemoModel>);
        }
    }
}
