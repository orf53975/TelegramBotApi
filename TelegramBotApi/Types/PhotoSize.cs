﻿using Newtonsoft.Json;

namespace TelegramBotApi.Types
{
    /// <summary>
    /// Represents one size of a photo or a file/sticker thumbnail
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class PhotoSize
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string FileId;

        /// <summary>
        /// Photo width
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width;

        /// <summary>
        /// Photo height
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height;

        /// <summary>
        /// Optional. File size
        /// </summary>
        [JsonProperty(PropertyName = "file_size")]
        public int FileSize;
    }
}
