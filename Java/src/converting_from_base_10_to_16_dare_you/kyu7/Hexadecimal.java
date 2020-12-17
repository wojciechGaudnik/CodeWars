package converting_from_base_10_to_16_dare_you.kyu7;

public class Hexadecimal {

	public static void main(String[] args) {
		System.out.println(convertToHex(256));
	}

	public static String convertToHex(int a){
		return "0x" + Integer.toHexString(a).toUpperCase();
	}
}
