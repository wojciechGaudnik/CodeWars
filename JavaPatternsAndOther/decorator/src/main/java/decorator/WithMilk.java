package decorator;

public class WithMilk extends CoffeeDecorator {

	Coffee coffee;

	public WithMilk(Coffee coffee) {
		this.coffee = coffee;
	}

	@Override
	public double cost() {
		return coffee.cost() + .25;
	}

	@Override
	public String getDescription() {
		return coffee.getDescription() + ", with milk";
	}
}
