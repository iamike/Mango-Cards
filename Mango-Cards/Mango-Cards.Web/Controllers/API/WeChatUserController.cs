﻿using System.Web;
using System.Web.Http;
using Mango_Cards.Web.Infrastructure;
using Mango_Cards.Web.Infrastructure.Filters;

namespace Mango_Cards.Web.Controllers.API
{
    [Authorize]
    public class WeChatUserController : BaseApiController
    {
        public object Get()
        {

            return HttpContext.Current.User.Identity.GetUser();
        }
    }
}
