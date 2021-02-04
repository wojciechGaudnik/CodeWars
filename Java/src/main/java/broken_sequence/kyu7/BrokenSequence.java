package broken_sequence.kyu7;

public class BrokenSequence{
	public static void main(String[] args) {
		var test = new BrokenSequence();
		System.out.println(test.findMissingNumber(  "2 1 4 3 a"));
		var test2 = "1 2 3 4 ";
		System.out.println(test2.matches(".*[a-b].*"));
	}

	public int findMissingNumber(String sequence) {
		if (sequence.equals("")) {
			return 0;
		}
		if (sequence.matches( ".*[a-b].*")){
			return 1;
		}
		var numbers = sequence.split(" ");
		for (var i = 1; i <= numbers.length; i++) {
			if (!sequence.contains(String.valueOf(i))) {
				return i;
			}
		}
		return 0;
	}
}
