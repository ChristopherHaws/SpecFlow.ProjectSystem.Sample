﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

[assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass)]

namespace SpecFlow.ProjectSystem.XunitTests
{
	[Binding]
	public sealed class StepDefinition1
	{
		private IList<Int32> numbers = new List<Int32>();
		private Int32 result;

		[Given("I have entered (.*) into the calculator")]
		public void GivenIHaveEnteredSomethingIntoTheCalculator(Int32 number)
		{
			this.numbers.Add(number);
		}

		[When("I press add")]
		public void WhenIPressAdd()
		{
			Thread.Sleep(5000);
			this.result = this.numbers.Sum();
		}

		[Then("the result should be (.*) on the screen")]
		public void ThenTheResultShouldBe(Int32 result)
		{
			Assert.Equal(result, this.result);
		}
	}
}
