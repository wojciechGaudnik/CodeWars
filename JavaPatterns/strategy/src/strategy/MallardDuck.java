package strategy;

public class MallardDuck extends Duck {

	MallardDuck(FlyBehaviour flyBehaviour) {
		super(flyBehaviour);
	}

	public void performFly() {
		flyBehaviour.fly();
	}
}
