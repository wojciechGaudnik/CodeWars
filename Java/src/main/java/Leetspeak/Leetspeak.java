package Leetspeak;

import java.util.HashMap;
import java.util.Map;

public class Leetspeak extends Encoder{

	public String encode(String source){
		if (source == null || source.length() == 0) {
			return "";
		}
		Map<Character, String> code = new HashMap<>(){{
			put('a', "4");
			put('e', "3");
			put('l', "1");
			put('m', "/^^\\");
			put('o', "0");
			put('u', "(_)");
		}};

		StringBuilder out = new StringBuilder();
		for (Character c : source.toCharArray()) {
			if (code.containsKey(Character.toLowerCase(c))) {
				out.append(code.get(Character.toLowerCase(c)));
			} else {
				out.append(c);
			}
		}
		return out.toString();
	}
}

abstract class Encoder{
	public abstract String encode(String source);
}
