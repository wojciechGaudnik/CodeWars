package diophantine_equation.kyu5;

public class Dioph {


	public static String solEquaStr(long n) {
		var answer = new StringBuilder().append("[");
		long x = 0;
		long y = 0;
		var first = 0;
		var second = n;
		while (first <= second) {
			if ((first + second) % 2 == 0 && (second - first) % 4 == 0) {
				x = (first + second) / 2;
				y = (second - first) / 4;
				if ((x - 2 * y) * (x + 2 * y) == n) {
					answer.append("[").append(x).append(", ").append(y).append("], ");
				}
			}
			while (n % ++first != 0) {
			}
			second = n / first;
		}
		if (answer.toString().equals("[")) return answer.append("]").toString();
		answer.deleteCharAt(answer.length() - 2).deleteCharAt(answer.length() - 1);
		return answer.append("]").toString();
	}
}
   
