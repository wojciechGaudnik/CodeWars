package StringPolynomialConverter;

public class Polinomio {

	public static void main(String[] args) {
//		System.out.println(convertToString(new int[]{0,1,-1,0,5,0,0,1}));
		System.out.println(convertString(new int[]{1,0,0,0,0}));
	}

	public static String convertString(int[] pol) {
		if (pol.length == 0) return "";
		StringBuilder answer = new StringBuilder();
		for (int i = pol.length - 1; i >= 1; i--) {
			if (pol[i] > 0) {
				answer
						.append("+")
						.append(pol[i])
						.append("x^").append(i);
			} else if (pol[i] < 0) {
				answer
						.append(pol[i])
						.append("x^").append(i);
			}
		}
		return answer.append((pol[0] != 0)?"+" + pol[0]:"").toString().replaceAll("(^\\+|\\^1)|1(?=x)|(\\^0)|\\+(?=-)", "");
	}
}
