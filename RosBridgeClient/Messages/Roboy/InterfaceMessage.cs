using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class InterfaceMessage : Message
    {
        [JsonIgnore] public const string RosMessageName = "roboy_middleware_msgs/InfoNotification";

        public Int32 id;
        public byte[] data;

        public InterfaceMessage()
        {
            id = new Int32();
            data = new byte[1];
        }

        public InterfaceMessage(int id, byte[] data)
        {
            this.id = id;
            this.data = data;
        }
    }
}