using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class NotifyChallengeAttribute : TypeFilterAttribute
    {
        public NotifyChallengeAttribute() : base(typeof(ChallengeNotificationFilterImpl)) { }

        private class ChallengeNotificationFilterImpl : IActionFilter
        {
            private readonly IProgressNotificationService _notifier;

            public ChallengeNotificationFilterImpl(IProgressNotificationService notifier)
            {
                _notifier = notifier;
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
                var policy = context.FindEffectivePolicy<AuthorizeFilter>();
                if (policy == null) return;

                var satisfiedRequirements = policy.Policy.Requirements;
                // todo: i think capturing the claims collection might be a PII issue, so unused for now
                //var claimsBag = context.HttpContext.User.Claims.Select(x => new KeyValuePair<string, string>(x.Type, x.Value));
                var message = new NotificationMessage(satisfiedRequirements);//, claimsBag);

                _notifier.Notify(message);
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {

            }
        }
    }
}