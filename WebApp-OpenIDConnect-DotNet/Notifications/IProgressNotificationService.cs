using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public interface IProgressNotificationService
    {
        void Notify(string tid, string cid, IEnumerable<string> satisfiedAuthorizationPolicyNames);
        void Notify(NotificationMessage message);
        void Notify(IEnumerable<IAuthorizationRequirement> satisfiedRequirements);
    }

    
}
