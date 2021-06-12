package strategy;

public abstract class Duck {
	protected FlyBehaviour flyBehaviour;

	Duck(FlyBehaviour flyBehaviour) {
		this.flyBehaviour = flyBehaviour;
	}

	public void performFly() {
		flyBehaviour.fly();
	}

	public void swim() {
		System.out.println(this.getClass() + " swim");
	}

}
