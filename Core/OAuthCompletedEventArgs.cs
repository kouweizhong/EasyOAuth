﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOAuth.Core
{
    public class OAuthCompletedEventArgs : EventArgs
    {
        public string Data { get; set; }
    }
}