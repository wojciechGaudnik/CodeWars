package double_dispatch;

import org.joda.money.Money;
import single.dispatch.OrderLine;
import visitor.OrderVisitor;

import java.math.RoundingMode;
import java.util.List;

public class Order extends single.dispatch.Order implements Visitable<OrderVisitor> {
	public Order(List<OrderLine> orderLines) {
		super(orderLines);
	}

	public Money totalCost(SpecialDiscountPolicy discountPolicy) {
		return totalCost().multipliedBy(1 - applyDiscountPolicy(discountPolicy), RoundingMode.HALF_UP);
	}

	protected double applyDiscountPolicy(SpecialDiscountPolicy discountPolicy) {
		return discountPolicy.discount(this);
	}

	@Override
	public void accept(OrderVisitor visitor) {
		visitor.visit(this);
	}
}