﻿using System.Configuration;

namespace Geocoding.Tests
{
    public class MapQuestOpenBatchGeocoderTest : BatchGeocoderTest
    {
        protected override IBatchGeocoder CreateBatchGeocoder()
        {
            string k = ConfigurationManager.AppSettings["mapQuestKey"];
            return new MapQuest.MapQuestGeocoder(k) { UseOSM = true };
        }
    }
}
