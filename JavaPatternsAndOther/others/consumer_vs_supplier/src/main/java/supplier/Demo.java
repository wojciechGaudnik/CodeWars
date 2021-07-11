package supplier;

import consumer.Duck;

import java.util.List;
import java.util.function.Supplier;

public class Demo {
	public static void main(String[] args) {
		var ducks = List.of(
				new Duck("duck 1", 87),
				new Duck("duck 2", 88),
				new Duck("duck 3", 89),
				new Duck("duck 4", 888)
		);

		Supplier<Duck> supplier = () -> ducks.stream().filter(d -> d.getName().equals("duck 6")).findFirst().orElse(new Duck("Default", 666));
		System.out.println(supplier.get());
	}
}
