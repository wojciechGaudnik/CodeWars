package ny_pizza_factory.pizza.store;

import ny_pizza_factory.pizza.Pizza;

import java.util.Optional;

public abstract class PizzaStore {

	public Optional<Pizza> orderPizza(String type) {
		Optional<Pizza> pizza = createPizza(type);

		pizza.ifPresent(p -> {
			p.prepare();
			p.bake();
			p.cut();
			p.box();
		});

		return pizza;
	}

	protected abstract Optional<Pizza> createPizza(String type);
}
