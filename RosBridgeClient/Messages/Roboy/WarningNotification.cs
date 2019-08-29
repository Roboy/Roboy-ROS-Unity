using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class WarningNotification : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "roboy_middleware_msgs/WarningNotification";

        public Int32 code;
        public String @object;
        public String msg;
        public String extra;
        public Int32 validity_duration;

        public WarningNotification()
        {
            code = new Int32();
            @object = "";
            msg = "";
            extra = "";
            validity_duration = new Int32();
        }

        public WarningNotification(int code, string @object, string msg, string extra, int validity_duration)
        {
            this.code = code;
            this.@object = @object;
            this.msg = msg;
            this.extra = extra;
            this.validity_duration = validity_duration;
        }
    }
}
