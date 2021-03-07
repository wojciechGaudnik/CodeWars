package remove_the_parentheses.kyu7;

import org.junit.jupiter.api.Test;

class KataTest {
	@Test
	public void basicTests() {
		for (String[] trial : new String[][]{
				{"example(unwanted thing)example", "exampleexample"},
				{"example(unwanted thing)example", "exampleexample"},
				{"example (unwanted thing) example", "example  example"},
				{"a (bc d)e", "a e"},
				{"a(b(c))", "a"},
				{"hello example (words(more words) here) something", "hello example  something"},
				{"(first group) (second group) (third group)", "  "}}) {

		}
//			Tester.doTest(trial[0], trial[1]);
	}
}