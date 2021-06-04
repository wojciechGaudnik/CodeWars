package java_functional_programming_part_1_the_beginning.kyu7;
import org.junit.Test;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

public class FunctionalProgrammingTest {
	@Test
	public void testJohnSmith() throws Exception {
		Student jSmith = new Student("John", "Smith", "js123");
		assertTrue("John Smith with student number js123 did not return true", FunctionalProgramming.f.apply(jSmith));
	}
}