using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AR30Web.Models.ViewModels
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? Id { get; set; }
        public int? AnnounceId { get; set; }
        public int? IssuerId { get; set; }
        public string UserId { get; set; }

        public string ActionParameters {
            get {
                var param = new StringBuilder("?");
                if (Id != null && Id > 0)
                    param.Append(String.Format("{0}={1}&", "id", Id));

                if (AnnounceId != null && AnnounceId > 0)
                    param.Append(String.Format("{0}={1}&", "announceId", AnnounceId));

                if (IssuerId != null && IssuerId > 0)
                    param.Append(String.Format("{0}={1}&", "issuerId", IssuerId));

                //if (SubscriptionId != null && SubscriptionId > 0)
                //    param.Append(String.Format("{0}={1}&", "subscriptionId", SubscriptionId));

                if (UserId != null && !UserId.Equals(string.Empty))
                    param.Append(string.Format("{0}={1}&", "userId", UserId));

                return param.ToString().Substring(0, param.Length - 1);
            }
        }
    }
}