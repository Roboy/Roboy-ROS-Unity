using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Services.Roboy
{
    public class VRPuppetStateTransmissionRequest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "vr_puppets/state_transmission";

        public bool data;

        public VRPuppetStateTransmissionRequest(bool data)
        {
            this.data = data;
        }
    }

    public class VRPuppetStateTransmissionResponse : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "vr_puppets/state_transmission";
        public bool success;
        public string message;
        public VRPuppetStateTransmissionResponse(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }
    }
}