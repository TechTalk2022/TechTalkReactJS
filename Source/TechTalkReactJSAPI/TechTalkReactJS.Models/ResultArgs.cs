using System;
using System.Collections.Generic;
using System.Text;

namespace TechTalkReactJS.Models
{
    public class ResultArgs
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public object ResultData { get; set; }

    }
}
