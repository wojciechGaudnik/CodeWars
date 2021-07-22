package double_dispatch;

import single.dispatch.DiscountPolicy;

public interface SpecialDiscountPolicy extends DiscountPolicy {
	double discount(SpecialOrder order);
}
