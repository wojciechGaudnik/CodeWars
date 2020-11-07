package simple_beads_count.kyu7;

public class BeadsCounter {

	public static int countRedBeads(final int nBlue) {
		if (nBlue <= 2) {
			return 0;
		}
		return (nBlue - 1) * 2;
	}
}
   
