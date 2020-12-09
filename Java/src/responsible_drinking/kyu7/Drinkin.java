package responsible_drinking.kyu7;

public class Drinkin {
	public static void main(String[] args) {
		var test = new Drinkin();
		System.out.println(test.hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer"));
	}

	public String hydrate(String drinkString) {
		var answer = 0;
		var test = drinkString.matches("\\d+");
		for (var one : drinkString.split(" ")) {
			if (one.matches("\\d+")){
				answer += Integer.parseInt(one);
			}
		}
		if (answer == 1) {
			return "1 glass of water";
		}
		return answer + " glasses of water";
	}
}
