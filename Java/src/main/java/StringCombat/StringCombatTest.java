package StringCombat;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.util.LinkedList;
import java.util.List;


public class StringCombatTest {

	private static List<String[]> tests = new LinkedList<>();

	@Before
	public void setUp() {
		tests.clear();
	}

	@Test
	public void shouldPassBasicTests() {
		tests.add(new String[]{"a", "a", "Draw", "string equivalence signifies instant draw"});
		tests.add(new String[]{"a", "b", "Winner: s2(a)", "expected b to outwin a"});
		tests.add(new String[]{"q", "b", "Winner: s1(f)", "expected q to outwin b"});
		tests.add(new String[]{"dog", "cat", "Draw"});
		tests.add(new String[]{"boy", "girl", "Winner: s2(fl)"});
		tests.add(new String[]{"abcde", "fghij", "Winner: s2(cj)"});
		tests.add(new String[]{"abCde", "fghij", "Winner: s1(b)"});
		tests.add(new String[]{"iGnfQxJYy", "MlHGtsGF", "Winner: s2(k)"});
		tests.add(new String[]{"vyTcJSGRGZcTq", "GFyfgBkDxNvgf", "Winner: s1(f)"});
		tests.add(new String[]{"vyTcJSGRGZcTq", "GFyfgBkDxNvgeq", "Draw"});
		executeTestBundle("basic tests bundle");
	}

	/**
	 * Test execution helper
	 */
	private void executeTestBundle(String bundleName) {
		System.out.println("------Executing " + bundleName + "------");
		tests.forEach(test -> {
			String s1 = test[0], s2 = test[1], expected = test[2], msg = test.length > 3 ? test[3] : "",
					actual = StringCombat.combat(s1, s2);
			Assert.assertEquals(msg, expected, actual);
			System.out.printf("`%s` duels against `%s` : %s%n", s1, s2, actual);
		});
		System.out.println("------   end of bundle   ------");
	}


}