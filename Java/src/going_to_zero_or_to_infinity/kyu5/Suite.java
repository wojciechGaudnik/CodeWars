package going_to_zero_or_to_infinity.kyu5;

import java.math.BigDecimal;
import java.math.RoundingMode;

public class Suite {

	public static double going(int n) {
		var answer = BigDecimal.valueOf(1).setScale(6, RoundingMode.UNNECESSARY);
		var number = BigDecimal.valueOf(1).setScale(6, RoundingMode.UNNECESSARY);
		var sum = BigDecimal.valueOf(1).setScale(6, RoundingMode.UNNECESSARY);
		while (number.compareTo(BigDecimal.valueOf( (n - 1))) < 0) {
			answer = answer.add(answer.multiply(number));
			number = number.add(BigDecimal.valueOf(1));
			sum = sum.add(answer);
		}
		answer = answer.add(answer.multiply(number));
		return sum.divide(answer, RoundingMode.FLOOR).setScale(6, RoundingMode.FLOOR).doubleValue() + 1;
	}
}
