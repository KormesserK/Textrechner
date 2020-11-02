using System;
using TechTalk.SpecFlow;

namespace TestRechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the number is PI(.*)")]
        public void GivenTheNumberIsPI(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"sin is (.*)")]
        public void ThenSinIs(int p0)
        {
            Assert.Equals(Math.Sin(Math.PI), p0);
        }
        
        [Then(@"Cos is (.*)")]
        public void ThenCosIs(int p0)
        {
            Assert.Equals(Math.Sin(Math.PI), p0);
        }
        
        [Then(@"tan is (.*)")]
        public void ThenTanIs(int p0)
        {
            Assert.Equals(Math.Sin(Math.PI), p0);
        }
    }
}
