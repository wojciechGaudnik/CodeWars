package People;

import org.junit.Test;
import static org.junit.Assert.*;
import org.junit.runners.JUnit4;
import java.security.SecureRandom;
import java.math.BigInteger;
import java.lang.reflect.*;

public class PeopleTest {

	@Test
	public void testSample() {
		People person = People.builder().name("Adam").lastName("Savage").age(25).city("San Francisco").job("Unchained Reaction").build();
		assertEquals(
				"Adam",
				person.getName()
		);
		assertEquals(
				"hello my name is Adam",
				person.greet()
		);
	}
}
