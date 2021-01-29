package longest_vowel_chain.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals(3,Solution.solve("ultrarevolutionariees"));
		assertEquals(2,Solution.solve("codewarriors"));
		assertEquals(3,Solution.solve("suoidea"));
		assertEquals(1,Solution.solve("strengthlessnesses"));
		assertEquals(11,Solution.solve("mnopqriouaeiopqrstuvwxyuaeiouaeiou"));
	}
}