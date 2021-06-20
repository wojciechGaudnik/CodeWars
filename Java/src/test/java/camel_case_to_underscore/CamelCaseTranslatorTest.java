package camel_case_to_underscore;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class CamelCaseTranslatorTest {
	@Test
	public void simpleUnitNameTests()
	{
		assertEquals("This_Is_A_Unit_Test", CamelCaseTranslator.toUnderScore("ThisIsAUnitTest"));
		assertEquals("This_Should_Be_Splitted_Correct_Into_Underscore", CamelCaseTranslator.toUnderScore("ThisShouldBeSplittedCorrectIntoUnderscore"));
	}

	@Test
	public void calculationUnitNameTests()
	{
		assertEquals("Calculating_1_Plus_1_Equals_2", CamelCaseTranslator.toUnderScore("Calculating1Plus1Equals2"));
		assertEquals("Calculating_5_Plus_5_Equals_10", CamelCaseTranslator.toUnderScore("Calculating5Plus5Equals10"));
		assertEquals("Calculate_500_Divided_By_5_Equals_100", CamelCaseTranslator.toUnderScore("Calculate500DividedBy5Equals100"));
	}

	@Test
	public void underscoreContainingUnitNameTests()
	{
		assertEquals("This_Is_Already_Splitted_Correct", CamelCaseTranslator.toUnderScore("This_Is_Already_Splitted_Correct"));
		assertEquals("This_Is_Not_Splitted_Correct", CamelCaseTranslator.toUnderScore("ThisIs_Not_SplittedCorrect"));
		assertEquals("Adding_3_To_3_Should_Be_6", CamelCaseTranslator.toUnderScore("Adding_3To_3ShouldBe_6"));
		assertEquals("_If_A_Test_Start_And_Ends_With_Underscore_It_Should_Be_The_Same_", CamelCaseTranslator.toUnderScore("_IfATestStartAndEndsWithUnderscore_ItShouldBeTheSame_"));
	}
}