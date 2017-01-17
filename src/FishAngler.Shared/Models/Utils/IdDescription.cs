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

using Newtonsoft.Json;
using System;

namespace FishAngler.Shared.Models.Utils
{
    public class IdDescription<TIdType>
    {
        public TIdType Id { get; set; }

        public String Description { get; set; }

        public override string ToString()
        {
            return String.IsNullOrEmpty(Description) ? "-" : Description;
        }

        public String ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
