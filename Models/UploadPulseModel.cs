using System;
using System.Collections.Generic;
using System.Timers;

namespace ElFinderWeb31.Models
{
    public class UploadPulseModel
    {
        public List<string> UploadedFiles { get; set; }
        public DateTimeOffset LastPulse { get; set; }
        public Timer Timer { get; set; }
    }
}
