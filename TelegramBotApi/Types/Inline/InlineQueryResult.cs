﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Types.Inline
{
    /// <summary>
    /// This object represents one result of an inline query. Telegram clients currently support results of the following 20 types:
    /// InlineQueryResultCachedAudio, 
    /// InlineQueryResultCachedDocument, 
    /// InlineQueryResultCachedGif, 
    /// InlineQueryResultCachedMpeg4Gif, 
    /// InlineQueryResultCachedPhoto, 
    /// InlineQueryResultCachedSticker, 
    /// InlineQueryResultCachedVideo, 
    /// InlineQueryResultCachedVoice, 
    /// InlineQueryResultArticle, 
    /// InlineQueryResultAudio, 
    /// InlineQueryResultContact, 
    /// InlineQueryResultGame, 
    /// InlineQueryResultDocument, 
    /// InlineQueryResultGif, 
    /// InlineQueryResultLocation,
    /// InlineQueryResultMpeg4Gif,
    /// InlineQueryResultPhoto, 
    /// InlineQueryResultVenue, 
    /// InlineQueryResultVideo, 
    /// InlineQueryResultVoice, 
    /// </summary>
    public abstract class InlineQueryResult
    {
        public abstract string Type { get; set; }
        public abstract string Id { get; set; }
    }
}
