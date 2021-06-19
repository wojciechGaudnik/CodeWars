package ny_pizza_factory.pizza.NY;

import ny_pizza_factory.pizza.Pizza;

public class NYStyleCheesePizza extends Pizza {
	@Override
	public void prepare() {
		System.out.println("prepare " + NYStyleCheesePizza.class);
	}

	@Override
	public void bake() {
		System.out.println("bake " + NYStyleCheesePizza.class);
	}

	@Override
	public void cut() {
		System.out.println("cut " + NYStyleCheesePizza.class);
	}

	@Override
	public void box() {
		System.out.println("box " + NYStyleCheesePizza.class);
	}
}
