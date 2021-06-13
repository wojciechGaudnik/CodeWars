package consumer;

import java.util.function.Consumer;

class Demo {
	public static void main(String[] args) {
		Consumer<Duck> consumer = System.out::println;
		var duck = new Duck("duck name", 555);
		consumer.accept(duck);
	}
}

