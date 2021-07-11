package adapter;

import java.util.Random;

public class EnemyRobot {

	Random random = new Random();

	public void smashWithHands() {
		int attackDamage = random.nextInt(10) + 1;
		System.out.println("Enemy Robot Causes " + attackDamage + " Damage With Its Hands");
	}

	public void walkForward() {
		int movement = random.nextInt(5) + 1;
		System.out.println("Enemy Robot Walks Forward " + movement + " Spaces");
	}

	public void reactToHuman(String name) {
		System.out.println("Enemy Robot Tramps on " + name);
	}
}
