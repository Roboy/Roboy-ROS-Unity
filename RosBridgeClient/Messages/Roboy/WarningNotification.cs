﻿using System;
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
    }
}
