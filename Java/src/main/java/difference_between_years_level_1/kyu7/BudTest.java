package difference_between_years_level_1.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;


class BudTest {
	@Test
	void basicTest() {
		assertEquals(18, Bud.howManyYears("1997/10/10", "2015/10/10"), "For input \"1997/10/10, 2015/10/10\"");
		assertEquals(25, Bud.howManyYears("1990/10/10", "2015/10/10"), "For input \"1990/10/10, 2015/10/10\"");
		assertEquals(25, Bud.howManyYears("2015/10/10", "1990/10/10"), "For input \"2015/10/10, 1990/10/10\"");
		assertEquals(23, Bud.howManyYears("1992/10/24", "2015/10/24"), "For input \"1992/10/24, 2015/10/24\"");
		assertEquals(18, Bud.howManyYears("2018/10/10", "2000/10/10"), "For input \"2018/10/10, 2000/10/10\"");
	}
}