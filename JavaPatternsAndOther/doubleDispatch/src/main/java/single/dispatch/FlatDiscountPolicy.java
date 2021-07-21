package single.dispatch;

public class FlatDiscountPolicy implements DiscountPolicy{
	@Override
	public double discount(Order order) {
		return 0.01d;
	}
}
