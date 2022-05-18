package matrix_addition_of_elements.kyu7;


import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class SumOfElementsTest {
	@Test
	public void test1() {
		int a[][] = {{1, 0}, {0, 1}};
		int b[][] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
		int c[][] = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 2}};
		assertEquals(Sid.sumOfElements(a), 2);
		assertEquals(Sid.sumOfElements(b), 45);
		assertEquals(Sid.sumOfElements(c), 122);
	}
}