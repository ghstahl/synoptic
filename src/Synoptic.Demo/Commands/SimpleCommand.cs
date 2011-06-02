﻿using System;

namespace Synoptic.Demo.Commands
{
    [Command]
    public class SimpleCommand
    {
        [CommandAction]
        public void Go([CommandParameter("xx|x")]string someString, int someNumber)
        {
            Console.Out.WriteLine("someString: {0}", someString);
            Console.Out.WriteLine("someNumber: {0}", someNumber);
        }
    }
}