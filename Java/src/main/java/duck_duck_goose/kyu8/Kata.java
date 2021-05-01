package duck_duck_goose.kyu8;

public class Kata {

	public static String duckDuckGoose(Player[] players, int goose) {
		return players[(--goose % players.length)].name;
	}

}

class Player {
	public String name;

	Player(String name) {
		this.name = name;
	}
}
