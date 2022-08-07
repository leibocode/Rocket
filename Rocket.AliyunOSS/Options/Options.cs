using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.AliyunOSS.Options
{
    public class Options
    {
        public string AccessKeyId { get; set; }

        public string AccessKeySecret { get; set; }

        public string Host { get; set; }

        public string BucketName { get; set; }

        public string Protocol { get; set; } = "https";

        public int Expire { get; set; } = 600;

        public int MaxSize { get; set; } = 10485760;
    }
}
