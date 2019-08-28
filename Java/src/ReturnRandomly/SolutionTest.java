package ReturnRandomly;

import org.junit.BeforeClass;
import org.junit.Test;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;
import java.util.stream.Collectors;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

public class SolutionTest {

	private static int count = 60_000;
	private static double threshold = 0.005;
	private static int[] results = new int[count];
	private static Set<Integer> setResults = new HashSet<>();

	@BeforeClass
	public static void beforeClass() {
		for (int i = 0; i < count; i++) {
			results[i] = Main.oneTwoThree();
			setResults.add(results[i]);
		}
	}

	@Test
	public void testOneTwoThreeMustBePresent() {
		assertTrue(setResults.contains(1));
		assertTrue(setResults.contains(2));
		assertTrue(setResults.contains(3));
	}

	@Test
	public void testShouldNotContainInvalidNumbers() {
		assertEquals(3, setResults.size());
	}

	@Test
	public void testAllNumbersMustBePresentsWithEqualProbability() {
		assertTrue(numberOfResultHasProbability(1, 1.0 / 3));
		assertTrue(numberOfResultHasProbability(2, 1.0 / 3));
		assertTrue(numberOfResultHasProbability(3, 1.0 / 3));
	}

	private boolean numberOfResultHasProbability(int number, double probability) {
		return (countOf(number) * 1.0 / count) - probability < threshold;
	}

	private long countOf(int number) {
		return Arrays.stream(results).filter(n -> n == number).count();
	}
}