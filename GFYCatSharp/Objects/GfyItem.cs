using System.Collections.Generic;
using Newtonsoft.Json;

namespace GFYCatSharp.Objects
{
    public class GfyItem
    {

        [JsonProperty(PropertyName = "gfyItem")]
        public GfyItemExtend Item { get; set; }

        [JsonProperty(PropertyName = "gfycats")]
        public IEnumerable<GfyItemExtend> Gfycats { get; set; }

        public string Url { get; set; }
    }

    public class GfyItemExtend
    {
        [JsonProperty("gfyId")]
        public string Id { get; set; }

        [JsonProperty("GfyName")]
        public string Name { get; set; }

        [JsonProperty("gfyNumber")]
        public int Number { get; set; }

        [JsonProperty("WebmUrl")]
        public string UrlWebm { get; set; }

        [JsonProperty("GifUrl")]
        public string UrlGif { get; set; }

        [JsonProperty("MobileUrl")]
        public string UrlMobile { get; set; }

        [JsonProperty("MobilePosterUrl")]
        public string UrlMobilePoster { get; set; }

        [JsonProperty("MiniUrl")]
        public string UrlMini { get; set; }

        [JsonProperty("MiniPosterUrl")]
        public string UrlMiniPoster { get; set; }

        [JsonProperty("PosterUrl")]
        public string UrlPoster { get; set; }

        [JsonProperty("Thumb360Url")]
        public string UrlThumb360 { get; set; }

        [JsonProperty("Thumb360PosterUrl")]
        public string UrlThumb360Poster { get; set; }

        [JsonProperty("Thumb100PosterUrl")]
        public string UrlThumb100Poster { get; set; }

        [JsonProperty("Max5MbGif")]
        public string UrlMax5MbGif { get; set; }

        [JsonProperty("Max2MbGif")]
        public string UrlMax2MbGif { get; set; }

        [JsonProperty("Max1MbGif")]
        public string UrlMax1MbGif { get; set; }

        [JsonProperty("Gif100Px")]
        public string UrlGif100Px { get; set; }

        [JsonProperty("MjpgUrl")]
        public string UrlMjpg { get; set; }

        [JsonProperty("WebpUrl")]
        public string UrlWebp { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [JsonProperty("avgColor")]
        public string AvarageColor { get; set; }

        public int FrameRate { get; set; }

        public int NumFrames { get; set; }

        [JsonProperty("Mp4Size")]
        public int SizeMp4 { get; set; }

        [JsonProperty("WebmSize")]
        public int SizeWebm { get; set; }

        [JsonProperty("GifSize")]
        public int SizeGif { get; set; }

        public string Source { get; set; }

        public string CreateDate { get; set; }

        public int Nsfw { get; set; }

        [JsonProperty("Mp4Url")]
        public string UrlMp4 { get; set; }

        public int Likes { get; set; }

        public int Published { get; set; }

        public int Dislikes { get; set; }

        public string ExtraLemmas { get; set; }

        public string Md5 { get; set; }

        public int Views { get; set; }

        public List<string> Tags { get; set; }
        //"tags": [
        //    "funny",
        //    "nursing",
        //    "overwatch"
        //],
        public string UserName { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public object LanguageCategories { get; set; }

        public string Subreddit { get; set; }

        public string RedditId { get; set; }

        public string RedditIdText { get; set; }
    }
}