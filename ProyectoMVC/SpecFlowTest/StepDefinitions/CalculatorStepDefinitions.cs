//using ProyectoMVC.Models;

//namespace SpecFlowTest.StepDefinitions
//{
//    [Binding]
//    public sealed class CalculatorStepDefinitions
//    {
//        private readonly    Calculator _calculator = new Calculator();
//        private int _result;
//        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

//        [Given("the first number is (.*)")]
//        public void GivenTheFirstNumberIs(int number)
//        {
//            _calculator.FirstNumber = number;
//        }

//        [Given("the second number is (.*)")]
//        public void GivenTheSecondNumberIs(int number)
//        {
//            _calculator.SecondNumber = number;
//        }

//        [When("the two numbers are added")]
//        public void WhenTheTwoNumbersAreAdded()
//        {
//            _result = _calculator.add();
//        }

//        [Then("the result should be (.*)")]
//        public void ThenTheResultShouldBe(int result)
//        {
//            _result.Should().Be(result);
//        }
//    }
//}
