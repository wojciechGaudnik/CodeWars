package where_is_vasya.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class WereIsVasyaTest {

	@Test
	public void test1(){
		assertEquals(2, WhereIsVasya.whereIsHe(3, 1, 1));
	}

	@Test
	public void test2(){
		assertEquals(3, WhereIsVasya.whereIsHe(5, 2, 3));
	}

}