using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.DTOs
{
    public class GlobalError
    {
        public int StatusCode { get; set; }
        public  string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
       
    }
}
