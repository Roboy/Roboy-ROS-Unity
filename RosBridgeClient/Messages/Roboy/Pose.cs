using System;
using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class Pose : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "roboy_middleware_msgs/Pose";

        public UInt16 id;
        public Point position;
        public Quaternion orientation;

        public Pose()
        {
            id = new int();
            position = new Point();
            orientation = new Quaternion();
        }
    }
}
