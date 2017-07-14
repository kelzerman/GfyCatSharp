using System;
using GFYCatSharp.Objects;

namespace GFYCatSharp
{
    public class GfyCatSharp
    {
        private readonly Agent _agent;

        #region Constructor

        public GfyCatSharp(Agent agent)
        {
            if (agent == null) throw new ArgumentNullException(nameof(agent));

            _agent = agent;
        }

        #endregion
        public GfyItem GetImageUrlById(string gfyId, EImageType type)
        {
            if (string.IsNullOrEmpty(gfyId)) throw new ArgumentNullException(nameof(gfyId));

            return _agent.Execute<GfyItem>($"gfycats/{gfyId}");
        }

        public GfyItem GetItemsByTag(string tag, int take = 10)
        {
            if (string.IsNullOrEmpty(tag)) throw new ArgumentNullException(nameof(tag));

            string subString = $"gfycats/trending?tagName={tag}&count={take}";
            GfyItem ret= _agent.Execute<GfyItem>(subString);

            ret.Url = _agent.BaseUrl + subString;

            return ret;
        }
    }
}
