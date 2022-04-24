package happy_birthday.kyu7;

import java.util.List;
import java.util.stream.Collectors;

public class WrapPresent{

	public static int wrap(int height, int width, int length){
		var list = List.of(height, width, length).stream().sorted().collect(Collectors.toList());
		return list.get(0) * 4 + list.get(1) * 2 + list.get(2) * 2 + 20;
	}
}
