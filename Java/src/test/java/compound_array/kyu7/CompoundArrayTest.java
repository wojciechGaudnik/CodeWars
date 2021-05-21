package compound_array.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;

public class CompoundArrayTest {
	@Test
	public void test1(){
		assertArrayEquals(new int[]{1,9,2,8,3,7,4,6,5,6}, CompoundArray.compoundArray(new int[] {1,2,3,4,5,6}, new int[] {9,8,7,6}));
	}

	@Test
	public void test2(){
		assertArrayEquals(new int[]{0,9,1,8,2,7,6,5,4,3,2,1,0}, CompoundArray.compoundArray(new int[] {0,1,2}, new int[] {9,8,7,6,5,4,3,2,1,0}));
	}
}