package ny_pizza_factory;

import ny_pizza_factory.pizza.Pizza;
import ny_pizza_factory.pizza.store.NYPizzaStore;
import ny_pizza_factory.pizza.store.PizzaStore;

import java.util.Optional;

public class Main {
	public static void main(String[] args) {
		PizzaStore nyPizzaStore = new NYPizzaStore();
		Optional<Pizza> pepperoniPizza = nyPizzaStore.orderPizza("pepperoni");
		System.out.println(pepperoniPizza.map(Pizza::toString));
	}
}
