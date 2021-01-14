package going_to_the_cinema.kyu7;

public class Movie {

	public static int movie(int card, int ticket, double perc) {
		double systemA = 0;
		double systemB = card;
		var answer = 0;
		while (Math.ceil(systemB) >= systemA) {
			systemA += ticket;
			systemB += (ticket * Math.pow(perc, ++answer));
		}
		return answer;
	}

}
