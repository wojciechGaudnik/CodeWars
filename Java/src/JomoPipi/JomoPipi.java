package JomoPipi;

import java.util.Arrays;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class JomoPipi {
	public static void main(String[] args) {
		char[][]a = new char[][]{{'a','b','c','d'},
				{'1','2','3','4'},
				{'c','o','d','e'},
				{'b','l','a','h'}};
		System.out.println(Arrays.deepToString(shift(a, 1)));
	}

	public static char[][] shift(char[][]m, int n){
		char[][] out1 = m.clone();
		char[][] out2 = new char[m.length][m[0].length];
		boolean flip = true;
		while (n-- > 0) {
			Arrays.stream(out1).flatMapToInt(x -> Arrays.stream(x)).collect(Collectors.toList())
		}
//			if (flip) {
//				out2[0][0] = out1[out1.length - 1][out1[out1.length - 1].length - 1];
//
//
//
//				flip = false;
//			} else {
//
//
//				flip = false;
//			}
//
//
////			System.out.println(last);
//		}
		//code
		return new char[][]{};
	}
//		char[] inOneLine = new char[m.length * m[0].length];



}
