package pizza_payments.kyu7;

import java.util.function.DoubleUnaryOperator;

public class PizzaPayments {
	private static final DoubleUnaryOperator round = x -> Math.round(x * 100.0) / 100.0;

	public static double michaelPays(double cost) {
		if (cost < 5) {
			return round.applyAsDouble(cost);
		} else if (cost * (1.0 / 3) <= 10) {
			return round.applyAsDouble(cost - (cost * (1.0 / 3)));
		} else{
			return round.applyAsDouble(cost - 10);
		}
	}


}
