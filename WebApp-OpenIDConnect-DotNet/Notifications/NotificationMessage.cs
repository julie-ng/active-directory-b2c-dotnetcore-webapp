using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class NotificationMessage
    {
        public string Identifier { get; set; }
        public IEnumerable<IAuthorizationRequirement> SatisfiedRequirements { get; set; }
        public IEnumerable<KeyValuePair<string, string>> AdditionalData { get; set; }

        public NotificationMessage(IEnumerable<IAuthorizationRequirement> satisfiedRequirements) : this(satisfiedRequirements, new List<KeyValuePair<string, string>>())
        {
            SatisfiedRequirements = satisfiedRequirements;
        }

        public NotificationMessage(IEnumerable<IAuthorizationRequirement> satisfiedRequirements, IEnumerable<KeyValuePair<string, string>> additionalData)
        {
            SatisfiedRequirements = satisfiedRequirements;
            AdditionalData = additionalData;
        }

        public NotificationMessage(string identifier, IEnumerable<IAuthorizationRequirement> satisfiedRequirements, IEnumerable<KeyValuePair<string, string>> additionalData)
        {
            Identifier = identifier;
            SatisfiedRequirements = satisfiedRequirements;
            AdditionalData = additionalData;
        }

        public NotificationMessage(string identifier, IEnumerable<IAuthorizationRequirement> satisfiedRequirements) : this(identifier, satisfiedRequirements, new List<KeyValuePair<string, string>>()) { }
    }
}