package y80_s_kids_1_how_many_licks_does_it_take.kyu7;

import org.junit.Test;

import java.util.HashMap;
import java.util.Map;

import static org.junit.Assert.assertEquals;

public class EightiesKids1Test {

	@Test
	public void test1() {
		Map<String, Integer> env = new HashMap<>(2, 1f);
		env.put("freezing temps", 10);
		env.put("clear skies", -2);
		assertEquals("It took 260 licks to get to the tootsie roll center of a tootsie pop. The toughest challenge was freezing temps.", EightiesKids1.totalLicks(env));
	}

	@Test
	public void test2() {
		Map<String, Integer> env = new HashMap<>(2, 1f);
		env.put("happiness", -5);
		env.put("clear skies", -2);
		assertEquals("It took 245 licks to get to the tootsie roll center of a tootsie pop.", EightiesKids1.totalLicks(env));
	}

	@Test
	public void test3() {
		assertEquals("It took 252 licks to get to the tootsie roll center of a tootsie pop.", EightiesKids1.totalLicks(new HashMap<>(0)));
	}

	@Test
	public void test4() {
		Map<String, Integer> env = new HashMap<>(3, 1f);
		env.put("dragons", 100);
		env.put("evil wizards", 110);
		env.put("trolls", 50);
		assertEquals("It took 512 licks to get to the tootsie roll center of a tootsie pop. The toughest challenge was evil wizards.", EightiesKids1.totalLicks(env));
	}

	@Test
	public void test5() {
		Map<String, Integer> env = new HashMap<>(1, 1f);
		env.put("white magic", -250);
		assertEquals("It took 2 licks to get to the tootsie roll center of a tootsie pop.", EightiesKids1.totalLicks(env));
	}
}