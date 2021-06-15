package decorator;

public class WithSugar  extends CoffeeDecorator{

	Coffee coffee;

	public WithSugar(Coffee coffee) {
		this.coffee = coffee;
	}

	@Override
	public double cost() {
		return coffee.cost() + .50;
	}

	@Override
	public String getDescription() {
		return coffee.getDescription() + " with sugar";
	}
}
