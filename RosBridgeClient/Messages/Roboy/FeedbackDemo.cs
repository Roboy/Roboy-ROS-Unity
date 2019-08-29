using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class FeedbackDemo : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "roboy_middleware_msgs/FeedbackDemo";

        public Int32 status;

        public FeedbackDemo()
        {
            status = new Int32();
        }

        public FeedbackDemo(int status)
        {
            this.status = status;
        }
    }
}
