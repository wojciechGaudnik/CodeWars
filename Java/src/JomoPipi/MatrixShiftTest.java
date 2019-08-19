//package JomoPipi;
//
//import org.junit.Test;
//
//import java.util.Arrays;
//
//import static org.junit.Assert.*;
//
//public class MatrixShiftTest {
//	@Test
//	public void test0() {
//		char[][]a = new char[][]{{'a','b','c','d'},
//				{'1','2','3','4'},
//				{'c','o','d','e'},
//				{'b','l','a','h'}};
//
//		char[][]b = new char[][]{{'h','a','b','c'},
//				{'d','1','2','3'},
//				{'4','c','o','d'},
//				{'e','b','l','a'}};
//		assertEquals(Arrays.deepToString(b),Arrays.deepToString(JomoPipi.shift(a,1)));
//	}
//	@Test
//	public void test1() {
//		char[][]a = new char[][]{{'b','o','o','b'}};
//
//		char[][]b = new char[][]{{'o','b','b','o'}};
//		assertEquals(Arrays.deepToString(b),Arrays.deepToString(JomoPipi.shift(a,2)));
//	}
//	@Test
//	public void test2() {
//		char[][]a = new char[][]{{'m','m','m'},
//				{'y','e','a'}};
//
//		char[][]b = new char[][]{{'y','e','a'},
//				{'m','m','m'}};
//		assertEquals(Arrays.deepToString(b), Arrays.deepToString(JomoPipi.shift(a,3)));
//	}
//}