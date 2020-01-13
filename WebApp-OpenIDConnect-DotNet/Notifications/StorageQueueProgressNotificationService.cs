using Azure.Storage.Queues;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class StorageQueueProgressNotificationService : IProgressNotificationService
    {
        private readonly QueueClient _queueClient;
        private readonly string _identifier;

        public StorageQueueProgressNotificationService(QueueClient qc, string tenantId = "")
        {
            _queueClient = qc;
            _identifier = tenantId;
        }

        public void Notify(NotificationMessage message)
        {
            _queueClient.SendMessage(JsonConvert.SerializeObject(message));
        }

        public void Notify(string tid, string cid, IEnumerable<string> satisfiedRequirements)
        {
            throw new System.NotImplementedException();
            //Notify(new NotificationMessage(tid, cid));
        }

        public void Notify(IEnumerable<IAuthorizationRequirement> satisfiedRequirements)
        {
            throw new System.NotImplementedException();
        }
    }
}