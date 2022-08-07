using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.AliyunOSS.Models
{
    public class AliyunToken
    {
        public string Host { get; set; }

        public string Key { get; set; }

        public string Bucket { get; set; }

        public string AccessKeyId { get; set; }

        public string Policy { get; set; }

        public string Signature { get; set; }
    }
}
