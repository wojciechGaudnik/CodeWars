package c_wars.kyu7;

public class CWars {
	public static void main(String[] args) {
		System.out.println(initials(""));
	}

	public static String initials(String name){
		System.out.println(name);
		var split = name.split(" ");
		var answer = new StringBuffer();
		for (var i = 0; i < split.length - 1; i++) {
			answer.append(Character.toUpperCase(split[i].charAt(0))).append(".");
		}
		var last = Character.toUpperCase(split[split.length - 1].charAt(0)) + split[split.length - 1].substring(1);
		return answer.append(last).toString();
	}
}
