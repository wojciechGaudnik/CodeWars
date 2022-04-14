package snakes_and_ladders.kyu5;

import java.util.HashMap;

public class SnakesLadders {
	private int player1 = 0;
	private int player2 = 0;
	private boolean p = true;
	private final HashMap<Integer, Integer> ladders = new HashMap<>();
	private final HashMap<Integer, Integer> snakes = new HashMap<>();

	public SnakesLadders() {
		ladders.put(2, 38);
		ladders.put(7, 14);
		ladders.put(8, 31);
		ladders.put(15, 26);
		ladders.put(21, 42);
		ladders.put(28, 84);
		ladders.put(36, 44);
		ladders.put(51, 67);
		ladders.put(71, 91);
		ladders.put(78, 98);
		ladders.put(87, 94);
		snakes.put(16, 6);
		snakes.put(46, 25);
		snakes.put(49, 11);
		snakes.put(62, 19);
		snakes.put(64, 60);
		snakes.put(74, 53);
		snakes.put(89, 68);
		snakes.put(92, 88);
		snakes.put(95, 75);
		snakes.put(99, 80);
	}

	public String play(int die1, int die2) {
		if (player1 == 100 || player2 == 100) return "Game over!";
		if (p) player1 = handleGame(player1, die1, die2);
		else player2 = handleGame(player2, die1, die2);
		if (player1 == 100) return "Player 1 Wins!";
		if (player2 == 100) return "Player 2 Wins!";
		var answer = String.format("Player %d is on square %d", (p) ? 1 : 2, (p) ? player1 : player2);
		if (die1 != die2) p = !p;
		return answer;
	}

	private int handleGame(int player, int die1, int die2) {
		player += die1 + die2;
		if (player > 100) player = 100 - player % 100;
		if (ladders.containsKey(player)) player = ladders.get(player);
		if (snakes.containsKey(player)) player = snakes.get(player);
		return player;
	}
}
