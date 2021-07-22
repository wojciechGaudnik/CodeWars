package double_dispatch;

import org.junit.jupiter.api.Test;
import single.dispatch.Order;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;
import static single.dispatch.OrderFixtureUtils.anyOrderLines;

class SpecialDiscountPolicyTest {

	@Test
	void test() {
		// given
		SpecialDiscountPolicy specialDiscountPolicy = new SpecialDiscountPolicy() {
			@Override
			public double discount(Order order) {
				return 0.01;
			}

			@Override
			public double discount(SpecialOrder order) {
				return 0.10;
			}
		};
		Order specialOrder = new SpecialOrder(anyOrderLines());

		// when
		double discount = specialDiscountPolicy.discount(specialOrder);

		// then
		assertThat(discount).isEqualTo(0.01);
	}
}