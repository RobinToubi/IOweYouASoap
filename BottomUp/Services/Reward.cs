using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BottomUp.Services
{
    [DataContract]
    public class Reward
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public string Label { get; set; }

        public Reward(string id, int value, string label)
        {
            this.Id = id;
            this.Value = value;
            this.Label = label;
        }
    }
}
