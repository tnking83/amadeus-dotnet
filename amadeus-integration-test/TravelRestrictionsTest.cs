﻿using amadeus;
using amadeus.resources;
using amadeus.travel.restrictions;
using Xunit;
using static amadeus_integration_test.TestUtil;

namespace amadeus_integration_test
{
    public class TravelRestrictionsTest
    {
        [Fact]
        public void Get_Restrictions()
        {
            var amadeus = GetAmadeusBuild();
            var travelRestrictions = new TravelRestrictions(amadeus);
            DiseaseAreaReport response = travelRestrictions.get(Params.with("countryCode", "US"));

            Assert.True(response != null);
            Assert.True(response.type == "covid19-area-report");
        }
    }
}
