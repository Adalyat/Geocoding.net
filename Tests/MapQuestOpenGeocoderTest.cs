﻿using Geocoding.MapQuest;
using System.Configuration;
using Xunit.Extensions;

namespace Geocoding.Tests
{
    public class MapQuestOpenGeocoderTest : GeocoderTest
	{
		protected override IGeocoder CreateGeocoder()
		{
			string k = ConfigurationManager.AppSettings["mapQuestKey"];
			return new MapQuestGeocoder(k) { UseOSM = true };
		}

		[Theory]
		[InlineData("Wilshire & Bundy, Los Angeles")]
		[InlineData("Fried St & 2nd St, Gretna, LA 70053")]
		public override void CanGeocodeWithSpecialCharacters(string address)
		{
			base.CanGeocodeWithSpecialCharacters(address);
		}
	}
}
