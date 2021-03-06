﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileServiceConstants
    {
        public const string AppUrl = "https://dronelandermobile1.azurewebsites.net";
    }

    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "07bb392f-bf00-4ccf-8f22-71c87f39b442";
        public const string iOSAppId = "";
    }

    public static class TelemetryConstants
    {
        public const string DisplayName = "Name";
        public const string Tagline = "Tag";
    }
}
