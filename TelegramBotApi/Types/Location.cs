﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Types
{
    /// <summary>
    /// This object represents a point on the map.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Location
    {
        /// <summary>
        /// Longitude as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "longtitude", Required = Required.Always)]
        public float Longtitude;

        /// <summary>
        /// Latitude as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude;
    }
}
