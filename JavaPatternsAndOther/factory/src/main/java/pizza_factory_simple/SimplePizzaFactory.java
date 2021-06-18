package pizza_factory_simple;

import java.util.Optional;

public class SimplePizzaFactory {
	public Optional<Pizza> makePizza(String pizzaType) {
		if (pizzaType.equals("pepperoni")) {
			return Optional.of(new PepperoniPizza());
		} else if (pizzaType.equals("cheese")) {
			return Optional.of(new CheesePizza());
		} else {
			return Optional.empty();
		}
	}
}
