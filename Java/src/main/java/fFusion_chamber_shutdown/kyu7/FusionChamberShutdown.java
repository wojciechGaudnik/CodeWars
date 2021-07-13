package fFusion_chamber_shutdown.kyu7;

public class FusionChamberShutdown {

	public static int[] burner(int c, int h, int o) {
		var water = Math.min(h / 2, o);
		o -= water;
		h -= water * 2;
		var carbonDioxide = Math.min(c, o / 2);
		var methane = Math.min(c, h / 4);
		return new int[]{water, carbonDioxide, methane};
	}

}