package fuel_calculator.kyu8;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void exampleTests(){
		assertEquals(5.65d, Kata.fuelPrice(5, 1.23d), 0.001d);
		assertEquals(18.40d, Kata.fuelPrice(8, 2.5d), 0.001d);
		assertEquals(27.50d, Kata.fuelPrice(5, 5.6d),  0.001d);
	}
}