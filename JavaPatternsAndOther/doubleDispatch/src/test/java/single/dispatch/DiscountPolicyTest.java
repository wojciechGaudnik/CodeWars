package single.dispatch;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import static org.assertj.core.api.Assertions.assertThat;

class DiscountPolicyTest {

	@DisplayName(
			"given two discount policies, " +
					"when use these policies, " +
					"then single dispatch chooses the impolementations based on runtime type"
	)
	@Test
	void test() throws Exception {
		// given
		DiscountPolicy floatPolicy = new FlatDiscountPolicy();
		DiscountPolicy amountPolicy = new AmountBasedDiscountPolicy();
		Order orderWorth501Dollars = orderWortNDollars(501);

		// when
		double floatDiscount = floatPolicy.discount(orderWorth501Dollars);
		double amountDiscount = amountPolicy.discount(orderWorth501Dollars);

		// then
		assertThat(floatDiscount).isEqualTo(0.01d);
		assertThat(amountDiscount).isEqualTo(0.10d);
	}

	private Order orderWortNDollars(int totalCost) {
		return new Order(OrderFixtureUtils.orderLineItemsWorthNDollars(totalCost));
	}
}