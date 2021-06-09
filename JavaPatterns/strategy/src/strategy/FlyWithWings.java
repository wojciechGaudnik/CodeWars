package strategy;

public class FlyWithWings implements FlyBehaviour {

	@Override
	public void fly() {
		System.out.println(this.getClass() + " I'm Flying!!!");
	}
}
