package spoonerize_me.kyu7;

public class Spooner {
	public static void main(String[] args) {
		var test = new Spooner();
		System.out.println(test.spoonerize("nit picking"));
	}

	public String spoonerize(String words) {
		var split = words.split(" ");
		return split[1].charAt(0) + split[0].substring(1) + " " + split[0].charAt(0) + split[1].substring(1);
	}
}
