package is_the_date_today.kyu8

import org.junit.Test;


class KataTest {

	@Test
	void isToday() {
		Date yesterday = new Date() - 1
		Date tomorrow = new Date() + 1
		assert Kata.isToday(new Date()) == true
		assert Kata.isToday(tomorrow) == false
		assert Kata.isToday(yesterday) == false
	}
}