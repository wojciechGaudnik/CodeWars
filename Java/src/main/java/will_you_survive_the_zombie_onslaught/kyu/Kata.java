package will_you_survive_the_zombie_onslaught.kyu;

public class Kata {

	public static String zombieShootout(int zombies, int range, int ammo) {
		range *= 2;
		var youShot = "You shot ";
		if (zombies <= (range) && zombies <= ammo) {
			return youShot + "all " + zombies + " zombies.";
		}
		if (ammo < range) {
			return youShot + ammo + " zombies before being eaten: " + "ran out of ammo.";
		}
		return youShot + range + " zombies before being eaten: " + "overwhelmed.";
	}

}