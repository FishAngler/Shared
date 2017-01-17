/*
 * Shared https://github.com/FishAngler/Shared
 * Author
 * Kevin D. Wolf @ByteMaster (FishAngler) 
 *
 * Released under the MIT License.
 *
 * v 1.0.0
 * 
 */

using System;

namespace FishAngler.Shared.Models.Imaging
{
    public class MediaSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Returns the height that should be used to maintain the current aspect ratio for the given width.
        /// </summary>
        public int GetScaledHeight(int width)
        {
            var scaleFactor = (float)width / (float)Width;
            return Convert.ToInt32(scaleFactor * Height);
        }

        /// <summary>
        /// Returns the width that should be used to maintain the current aspect ratio for the given height.
        /// </summary>
        public int GetScaleWidth(int height)
        {
            var scaleFactor = (float)height / (float)Height;
            return Convert.ToInt32(scaleFactor * Width);
        }
    }
}
