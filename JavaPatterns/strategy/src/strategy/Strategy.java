package strategy;

public class Strategy {
	public static void main(String[] args) {
		FlyBehaviour flyWithWins = new FlyWithWings();
		Duck mallardDuck = new MallardDuck(flyWithWins);

		mallardDuck.performFly();
	}
}
