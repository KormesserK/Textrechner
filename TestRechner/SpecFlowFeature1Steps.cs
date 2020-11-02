using System;
using TechTalk.SpecFlow;

namespace TestRechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the number is PI")]
        public void GivenTheNumberIsPI()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
