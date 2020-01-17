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
        void Notify(IEnumerable<IAuthorizationRequirement> satisfiedRequirements);
        void Notify(NotificationMessage message);
    }

    public interface IProgressNotificationService<T> : IProgressNotificationService
    {
        void Notify(IEnumerable<T> satisfiedRequirements);
    }
}
