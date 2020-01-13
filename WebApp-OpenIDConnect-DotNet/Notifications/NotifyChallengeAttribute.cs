using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

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
                var satisfiedResults = context.FindEffectivePolicy<AuthorizeFilter>();
                //satisfiedResults.Policy.Requirements
                _notifier.Notify("tid1", "cid1");
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {

            }
        }
    }
}