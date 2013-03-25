using System;

namespace Softbuild.Social
{
    /// <summary>
    /// Line URL content types extensions.
    /// </summary>
    public static class LineUrlContentTypesExtensions
    {
        public static string ToStringContentType(this LineUrlContentTypes e)
        {
            switch (e)
            {
                case LineUrlContentTypes.Text: return "text";
                case LineUrlContentTypes.Image: return "image";
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }

    /// <summary>
    /// Line URL content types.
    /// </summary>
    public enum LineUrlContentTypes
    {
        Text,
        Image,
    }
}

