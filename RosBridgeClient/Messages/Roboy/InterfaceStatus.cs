using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class InterfaceStatus : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "roboy_middleware_msgs/InterfaceStatus";

        public Int32 status;

        public InterfaceStatus()
        {
            status = new Int32();
        }

        public InterfaceStatus(int status)
        {
            this.status = status;
        }
    }
}
