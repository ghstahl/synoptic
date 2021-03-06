﻿using System;

namespace Synoptic.Service
{
    public class WindowsServiceConfiguration : IWindowsServiceConfiguration
    {
        private readonly string _serviceName;

        public WindowsServiceConfiguration(string serviceName)
        {
            if (String.IsNullOrEmpty(serviceName))
                throw new ArgumentNullException("serviceName");

            _serviceName = serviceName;
        }

        public string ServiceName
        {
            get { return _serviceName; }
        }

        public string CommandLineArguments { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
    }
}