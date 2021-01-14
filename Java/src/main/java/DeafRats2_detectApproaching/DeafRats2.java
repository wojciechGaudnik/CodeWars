package DeafRats2_detectApproaching;

import java.util.Arrays;

public class DeafRats2 {
	public static int countDeafRats(char[][] townSquare) {
		int yP = 0;
		int xP = 0;
		int count = 0;
		for (int i = 0; i < townSquare.length; i++) {
			if (Arrays.toString(townSquare[i]).contains("P")) {
				yP = i;
				xP = String.valueOf(townSquare[i]).indexOf("P");
				break;
			}
		}
		for (int yA = 0; yA < townSquare.length; yA++) {
			for (int xA = 0; xA < townSquare[yA].length; xA++) {
				int xV = 0, yV = 0;
				if (townSquare[yA][xA] == '↑') {
					xV = 0; yV = -1;
				} else if (townSquare[yA][xA] == '↓') {
					xV = 0; yV = 1;
				} else if (townSquare[yA][xA] == '←') {
					xV = -1; yV = 0;
				} else if (townSquare[yA][xA] == '→') {
					xV = 1; yV = 0;
				}else if (townSquare[yA][xA] == '↗') {
					xV = 1; yV = -1;
				}else if (townSquare[yA][xA] == '↘') {
					xV = 1; yV = 1;
				}else if (townSquare[yA][xA] == '↙') {
					xV = -1; yV = 1;
				}else if (townSquare[yA][xA] == '↖') {
					xV = -1; yV = -1;
				}else {
					continue;
				}
				double first = Math.sqrt(Math.pow(xP - xA, 2) + Math.pow(yP - yA, 2));
				double second = Math.sqrt(Math.pow(xP - xA - xV, 2) + Math.pow(yP - yA - yV, 2));
				count += (second > first)?1:0;
			}
		}
		return count;
	}
}
