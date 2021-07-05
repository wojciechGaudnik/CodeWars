package adding_values_of_arrays_in_a_shifted_way.kyu7;

public class Kata {

	public static int[] addingShifted(int[][] arrayOfArrays, int shift){
		var answer =  new int[arrayOfArrays[0].length + (arrayOfArrays.length - 1) * shift];
		var index = 0;
		for (var oneArray : arrayOfArrays) {
			var indexBuff = index;
			for (var one : oneArray) {
				answer[index] += one;
				index++;
			}
			index = indexBuff;
			index += shift;
		}
		return answer;
	}

}
