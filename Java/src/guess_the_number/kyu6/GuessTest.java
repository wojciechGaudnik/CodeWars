package guess_the_number.kyu6;

import org.junit.Assert;
import org.junit.Test;

public class GuessTest {

	@Test
	public void testBasic() {

		GuesserSolution solution = new GuesserSolution();
		solution.setAnswer(42);
		int guessed = solution.getNumber();
		Assert.assertEquals(42, guessed);
		System.out.println("You guessed " + guessed + " correctly!");
	}
}