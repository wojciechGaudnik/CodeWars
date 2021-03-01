package interactive_dictionary.kyu7;

import java.util.HashMap;

public class Dictionary {
	public static void main(String[] args) {

	}

	HashMap<String, String> map;

	public Dictionary(){
		map = new HashMap<>();
	}

	public void newEntry(String key, String value){
		map.put(key, value);
	}

	public String look(String key){
		return map.getOrDefault(key, "Cant find entry for " + key);
	}
}
