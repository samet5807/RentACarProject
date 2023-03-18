﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool success) : base(false)
        {
        }

        public ErrorResult( string message) : base(false, message)
        {
        }
    }
}
