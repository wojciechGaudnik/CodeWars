package adapter;

import java.util.Random;

public class EnemyTank implements EnemyAttacker {

	Random random = new Random();

	@Override
	public void fireWeapon() {
		int attackDamage = random.nextInt(10) + 1;
		System.out.println("Enemy Tank Does " + attackDamage + " Damage");
	}

	@Override
	public void driveForward() {
		int movement = random.nextInt(5) + 1;
		System.out.println("Enemy Tank Moves " + movement + " spaces");
	}

	@Override
	public void assignDriver(String driverName) {
		System.out.println(driverName + " is driving the tank");
	}
}
