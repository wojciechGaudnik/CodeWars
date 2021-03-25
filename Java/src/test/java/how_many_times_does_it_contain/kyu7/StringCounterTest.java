package how_many_times_does_it_contain.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class StringCounterTest {
	@Test
	public void exampleTests() {
		assertEquals(StringCounter.stringCounter("Hello World",'o'), 2);
		assertEquals(StringCounter.stringCounter("Wait isn't it supposed to be cynical?",'i'), 4);
		assertEquals(StringCounter.stringCounter("I'm gona be the best code warrior ever dad",'r'), 4);
		assertEquals(StringCounter.stringCounter("Do you like Harry Potter?",'?'), 1);
	}
}