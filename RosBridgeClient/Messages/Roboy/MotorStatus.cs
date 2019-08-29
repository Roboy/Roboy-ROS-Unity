using System;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Roboy
{
    public class MotorStatus : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "roboy_middleware_msgs/MotorStatus";

        public UInt16 id;
        public bool power_sense;
        public Int32[] pwm_ref;
        public Int32[] position;
        public Int32[] velocity;
        public Int32[] displacement;
        public Int16[] current;
        public Int32[] angle;

        public MotorStatus()
        {
            id = new int();
            power_sense = new bool();
            pwm_ref = new Int32[0];
            position = new Int32[0];
            velocity = new Int32[0];
            displacement = new Int32[0];
            current = new Int16[0];
            angle = new Int32[0];
        }

        public MotorStatus(ushort id, bool power_sense, int[] pwm_ref, int[] position, int[] velocity, int[] displacement, short[] current, int[] angle)
        {
            this.id = id;
            this.power_sense = power_sense;
            this.pwm_ref = pwm_ref;
            this.position = position;
            this.velocity = velocity;
            this.displacement = displacement;
            this.current = current;
            this.angle = angle;
        }
    }
}
