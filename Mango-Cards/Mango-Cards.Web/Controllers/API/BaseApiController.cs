﻿using System.Web.Http;
using Mango_Cards.Web.Models;

namespace Mango_Cards.Web.Controllers.API
{
    public class BaseApiController : ApiController
    {
        protected ResponseModel Success()
        {
            return new ResponseModel
            {
                ErrorCode = 0,
                Message = "success",
                Error = false
            };
        }
        protected ResponseModel Failed(string message)
        {
            return new ResponseModel
            {
                ErrorCode = 0,
                Message = message,
                Error = true
            };
        }
    }
}
