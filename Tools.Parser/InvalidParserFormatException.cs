﻿using System;

namespace Tools.Parser
{
    public class InvalidParserFormatException : Exception
    {
        public InvalidParserFormatException(string message)
            : base(message)
        {
        }

        public InvalidParserFormatException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }

}
