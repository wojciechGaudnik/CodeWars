package decorator;

public class Demo {

	public static void main(String[] args) {
		Coffee espresso = new Espresso();
		espresso = new WithMilk(espresso);
		espresso = new WithSugar(espresso);
		espresso = new WithSugar(espresso);

		System.out.println(espresso.getDescription());
		System.out.println(espresso.cost());
	}
}
