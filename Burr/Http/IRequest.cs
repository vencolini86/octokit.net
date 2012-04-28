﻿using System;
using System.Collections.Generic;

namespace Burr.Http
{
    public interface IRequest
    {
        Dictionary<string, string> Headers { get; }
        string Method { get; }
        Dictionary<string, string> Parameters { get; }
        Uri BaseAddress { get; }
        string Endpoint { get; }
    }
}