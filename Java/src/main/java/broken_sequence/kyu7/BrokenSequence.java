package broken_sequence.kyu7;

public class BrokenSequence{

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
