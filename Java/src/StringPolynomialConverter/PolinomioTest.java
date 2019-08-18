package StringPolynomialConverter;

import org.junit.Test;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.*;

public class PolinomioTest {

	@Test
	public void convertToString() {
		assertEquals("5x^4-2x^2+x", Polinomio.convertString(new int[]{0,1,-2,0,5}));
		assertEquals("-2x^2+x+1", Polinomio.convertString(new int[]{1,1,-2,0,0}));
		assertEquals("", Polinomio.convertString(new int[]{}));
		assertEquals("7x^2", Polinomio.convertString(new int[]{0,0,7,0,0}));
		assertEquals("1", Polinomio.convertString(new int[]{1,0,0,0,0}));
		assertEquals("x^7+5x^4-x^2+x", Polinomio.convertString(new int[]{0,1,-1,0,5,0,0,1}));
		assertEquals("4x^2-1", Polinomio.convertString(new int[]{-1, 0, 4, 0}));

	}

	@Test
	public void basicTests(){
		assertThat("error when pol={0,1}",Polinomio.convertString(new int[]{0,1}), is("x") );
		assertThat("error when pol={-1,0}",Polinomio.convertString(new int[]{-1,0}), is("-1") );
	}
}