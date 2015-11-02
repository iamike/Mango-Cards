using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mango_Cards.Library.Models.Interfaces;

namespace Mango_Cards.Library.Models
{
    public class Account:IDtStamped
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 微信用户Id
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string WeChatNickName { get; set; }
        /// <summary>
        /// 微信地理
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public virtual Company Company { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
