package will_you_survive_the_zombie_onslaught.kyu;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

// TODO: Replace examples and use TDD development by writing your own tests

public class SolutionTest {
	@Test
	public void exampleTests() {
		assertEquals("You shot all 3 zombies.", Kata.zombieShootout(3, 10, 10));
		assertEquals("You shot 16 zombies before being eaten: overwhelmed.", Kata.zombieShootout(100, 8, 200));
		assertEquals("You shot 8 zombies before being eaten: ran out of ammo.", Kata.zombieShootout(50, 10, 8));
	}
}