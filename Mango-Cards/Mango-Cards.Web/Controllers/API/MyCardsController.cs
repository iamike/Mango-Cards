﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Mango_Cards.Library.Models;
using Mango_Cards.Library.Services;
using Mango_Cards.Web.Infrastructure.Filters;
using Mango_Cards.Web.Models;

namespace Mango_Cards.Web.Controllers.API
{
    [Authorize]
    public class MyCardsController : BaseApiController
    {
        private readonly IWeChatUserService _weChatUserService;
        public MyCardsController(IWeChatUserService weChatUserService)
        {
            _weChatUserService = weChatUserService;
        }
        public object Get()
        {
            var wechatuser = _weChatUserService.GetWeChatUser(HttpContext.Current.User.Identity.GetUser().Id);
            Mapper.Reset();
            Mapper.CreateMap<MangoCard, MangoCardModel>().ForMember(n => n.HtmlCode, opt => opt.Ignore());
            Mapper.CreateMap<CardType, CardTypeModel>()
                .ForMember(n => n.MangoCardModels, opt => opt.MapFrom(src => src.MangoCards));
            return
                wechatuser.MangoCards.Where(n => !n.IsDeleted)
                    .GroupBy(n => n.CardType)
                    .Select(n => n.Key)
                    .Select(Mapper.Map<CardType, CardTypeModel>);
        }
        /// <summary>
        /// 获取基础数据
        /// </summary>
        /// <param name="id">mango card id</param>
        /// <returns></returns>
        public object Get(Guid id)
        {
            var wechatuser = _weChatUserService.GetWeChatUser(HttpContext.Current.User.Identity.GetUser().Id);
            Mapper.Reset();
            Mapper.CreateMap<CardType, CardTypeModel>();
            Mapper.CreateMap<MangoCard, MangoCardModel>()
                .ForMember(n => n.PvCount, opt => opt.MapFrom(src => src.PvDatas.Count))
                .ForMember(n => n.ShareTimeCount, opt => opt.MapFrom(src => src.ShareTimes.Count));
            return Mapper.Map<MangoCard, MangoCardModel>(wechatuser.MangoCards.FirstOrDefault(n => n.Id==id));
        }
    }
}
