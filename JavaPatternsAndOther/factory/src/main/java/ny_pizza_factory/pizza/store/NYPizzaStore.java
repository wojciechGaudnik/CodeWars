package ny_pizza_factory.pizza.store;

import ny_pizza_factory.pizza.NY.NYStyleCheesePizza;
import ny_pizza_factory.pizza.NY.NYStylePepperoniPizza;
import ny_pizza_factory.pizza.Pizza;

import java.util.Optional;

public class NYPizzaStore extends PizzaStore {
	@Override
	protected Optional<Pizza> createPizza(String pizzaType) {
		if (pizzaType.equals("pepperoni")) {
			return Optional.of(new NYStylePepperoniPizza());
		} else if (pizzaType.equals("cheese")) {
			return Optional.of(new NYStyleCheesePizza());
		} else {
			return Optional.empty();
		}
	}
}
