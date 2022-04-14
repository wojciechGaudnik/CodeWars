package be_concise_i_the_ternary_operator.kyu8;

public class C {
	static String describeAge(int a) {
		return "You're a(n) " + ((a <= 12) ? "kid" : (a <= 17) ? "teenager" : (a <= 64) ? "adult" : "elderly");
	}
}
