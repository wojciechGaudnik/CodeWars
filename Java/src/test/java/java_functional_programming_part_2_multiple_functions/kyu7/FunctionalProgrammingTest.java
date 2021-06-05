package java_functional_programming_part_2_multiple_functions.kyu7;

import org.junit.Test;
import static org.junit.Assert.assertEquals;


public class FunctionalProgrammingTest {
	@Test
	public void testArea() throws Exception {
		Triangle t = new Triangle(5, 10);
		assertEquals("Incorrect area returned", 25D, FunctionalProgramming.f.applyAsDouble(t), 0.001);
		assertEquals("Incorrect area in Triangle object", 25D, t.getArea(), 0.001);
	}
}