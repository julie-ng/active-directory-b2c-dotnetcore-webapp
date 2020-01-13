using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class NotificationMessage
    {
        public string Tid { get; set; }
        public string Cid { get; set; }
        public IEnumerable<IAuthorizationRequirement> SatisfiedRequirements { get; set; }

        public NotificationMessage(string tid, string cid, IEnumerable<IAuthorizationRequirement> satisfiedRequirements)
        {
            this.Tid = tid;
            this.Cid = cid;
            this.SatisfiedRequirements = satisfiedRequirements;
        }
    }
}