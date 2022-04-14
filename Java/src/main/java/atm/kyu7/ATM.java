package atm.kyu7;

public class ATM {

	public int solve(int n) {
		var answer = 0;
		for (var one : new int[]{500, 200, 100, 50, 20, 10}) {
			answer += n / one;
			n %= one;
		}
		return (n == 0) ? answer : -1;
	}
}
