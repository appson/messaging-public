﻿using System.Collections.Generic;

namespace FanapPlus.Ghasedak.Client.Models
{
    public class GhasedakSendResponse
    {
        public string Puid { get; set; }
        public IEnumerable<string> Muids { get; set; }
    }
}