using System.Net;
using NUnit.Framework;
using SpecFlowProject.Helper;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first score is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _scenarioContext.Set(number,"FirstScore");
        }

        [Given("the second score is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Set(number, "SecondScore");
        }

        [When("get the score display")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var firstScore = _scenarioContext.Get<int>("FirstScore");
            var secondScore = _scenarioContext.Get<int>("SecondScore");
            string scoreDisplay = TennisHelper.GetScoreDisplay(firstScore,secondScore);
            _scenarioContext.Set(scoreDisplay,"ScoreDisplay");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            //TODO: implement assert (verification) logic
            string scoreDisplay = _scenarioContext.Get<string>("ScoreDisplay");
            Assert.AreEqual(result , scoreDisplay);
        }
    }
}
