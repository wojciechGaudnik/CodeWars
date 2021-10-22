package converta_hex_string_to_rgb.kyu5;

class HexToRGB {

	public static int[] hexStringToRGB(String hex) {
		return new int[]{
				Integer.parseInt(hex.substring(1, 3), 16),
				Integer.parseInt(hex.substring(3, 5), 16),
				Integer.parseInt(hex.substring(5, 7), 16),
		};
	}
}