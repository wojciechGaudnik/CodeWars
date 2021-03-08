package email_address_obfuscator.kyu7;

public class EmailObfuscator {
	public static void main(String[] args) {

	}
	public static String obfuscate(String email) {
		return email.replaceAll("@", " [at] ").replaceAll("\\.", " [dot] ");
	}
}
