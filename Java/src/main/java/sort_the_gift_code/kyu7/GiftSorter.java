package sort_the_gift_code.kyu7;

import java.util.Arrays;

public class GiftSorter {

	public String sortGiftCode(String code) {
		var array = code.toCharArray();
		Arrays.sort(array);
		return String.valueOf(array);
	}
}
   
