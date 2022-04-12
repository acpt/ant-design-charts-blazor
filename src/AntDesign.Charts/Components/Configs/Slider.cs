using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntDesign.Charts
{
    public class Slider
    {
        [JsonPropertyName("start")]
        public double Start { get; set; }
        [JsonPropertyName("end")]
        public double End { get; set; }
    }
}


