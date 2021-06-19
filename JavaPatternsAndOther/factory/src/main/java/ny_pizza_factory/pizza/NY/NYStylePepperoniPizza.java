package ny_pizza_factory.pizza.NY;

import ny_pizza_factory.pizza.Pizza;

public class NYStylePepperoniPizza extends Pizza {
	@Override
	public void prepare() {
		System.out.println("prepare " + NYStylePepperoniPizza.class);
	}

	@Override
	public void bake() {
		System.out.println("bake" + NYStylePepperoniPizza.class);
	}

	@Override
	public void cut() {
		System.out.println("cut" + NYStylePepperoniPizza.class);
	}

	@Override
	public void box() {
		System.out.println("box" + NYStylePepperoniPizza.class);
	}
}
