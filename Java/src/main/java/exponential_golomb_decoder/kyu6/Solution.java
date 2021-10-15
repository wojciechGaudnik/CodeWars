package exponential_golomb_decoder.kyu6;

import java.util.ArrayList;

class Solution {
	public static int[] decoder(String sequence) {
		var answer = new ArrayList<Integer>();
		var temp = new StringBuilder();
		var tempI = 0;
		for (var i = 0; i < sequence.length(); i++) {
			if (sequence.charAt(i) == '0') {
				temp.append("0");
				tempI++;
				continue;
			}
			while (tempI-- >= 0) {
				temp.append(sequence.charAt(i++));
			}
			answer.add(Integer.parseInt(temp.toString(), 2) - 1);
			temp = new StringBuilder();
			tempI = 0;
			i--;
		}
		return answer.stream().mapToInt(Integer::intValue).toArray();
	}
}
