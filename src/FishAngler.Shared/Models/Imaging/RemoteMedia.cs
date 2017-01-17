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


using FishAngler.Shared.Models.Utils;
using System;

namespace FishAngler.Shared.Models.Imaging
{
    public enum MediaTypes
    {
        Photo = 1,
        Video = 2,
    }


    public class RemoteMedia
    {
        public const int MAX_IMAGE_UPLOAD_WIDTH = 1920;
        public const int MAX_IMAGE_UPLOAD_HEIGHT = 1920;

        public String MediaUri { get; set; }
        public IdDescription<int> MediaType { get; set; }
        public String PreviewUri { get; set; }
        public MediaSize Size { get; set; }
    }
}
