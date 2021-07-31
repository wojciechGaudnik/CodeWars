package rock_off.kyu7;

public class Solution {
	public static String solveRockOff(final int[] alice, final int[] bob) {
		var aliceScore = 0;
		var bobScore = 0;
		for (var i = 0; i < alice.length; i++) {
			if (alice[i] == bob[i]) {
				continue;
			}
			if (alice[i] > bob[i]) {
				aliceScore++;
			} else {
				bobScore++;
			}
		}
		if (aliceScore == bobScore) {
			return aliceScore + ", " + bobScore + ": that looks like a \"draw\"! Rock on!";
		}
		if (aliceScore > bobScore) {
			return aliceScore + ", " + bobScore + ": Alice made \"Kurt\" proud!";
		}
		return aliceScore + ", " + bobScore + ": Bob made \"Jeff\" proud!";
	}
}
