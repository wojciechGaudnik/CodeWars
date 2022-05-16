package bits_battle.kyu7;

import java.util.Arrays;

public class BitsBattle {

	static String bitsBattle(int[] numbers) {
		var evenZeros = Arrays.stream(numbers)
				.filter(o -> o != 0 && o % 2 == 0)
				.map(o -> Integer.toBinaryString(o).length() - Integer.bitCount(o))
				.sum();
		var odsOnes = Arrays.stream(numbers)
				.filter(o -> o % 2 != 0)
				.map(Integer::bitCount)
				.sum();
		if (evenZeros > odsOnes) {
			return "evens win";
		}
		if (odsOnes > evenZeros) {
			return "odds win";
		}
		return "tie";
	}

}