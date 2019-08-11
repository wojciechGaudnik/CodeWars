import java.math.BigInteger;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.function.Function;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) {
//		char a = 97 - 32;
//		System.out.println(a);
//
//		int first = 1989;
//		int second = 867;
//		int buff = 0;
//		int iter = 0;
//		while (first - second != 0) {
//			iter++;
//			if (second > first) {
//				buff = first;
//				first = second;
//				second = buff;
//			}
//			first -= second;
//		}
////		System.out.println(first + " " + second + " " + iter);
//
//		first = 51;
//		second = first * 2;
//		buff = 51;
//		int cache = 0;
//		iter = 6;
//
//		while (iter-- > 0) {
//			cache = second;
//			second += first;
//			first = cache;
//			System.out.println(first + " " + second);
//		}


//		while (iter-- > 0) {
//			System.out.println(first + " " + second + " " + iter);
//			first += second;
//			if (second > first) {
//				buff = first;
//				first = second;
//				second = buff;
//			}
//		}





//		first = 51;
//		second = 51;
//		iter = 7;
//		while (--iter > 0) {
//			if (first < second) {
//				first += second;
//			} else {
//				second += first;
//			}
//			System.out.println(first + " " + second);
//		}
//		System.out.println(first + " " + second + " " + iter);
//		int iter =




//		System.out.println(Arrays.toString(findInitialNumbers(51, 0)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 1)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 2)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 3)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 4)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 5)));
//		System.out.println(Arrays.toString(findInitialNumbers(51, 6)));
//
//		System.out.println(51-51);
//		System.out.println(51-102);
//		System.out.println(153-102);
//		System.out.println(255-102);
//		System.out.println(255-357);
//		System.out.println(255-612);
//		System.out.println(255-867);
//		System.out.println(1122-867);



    }





    public static int makeNegative(final int x) {

        return -Math.abs(x);

    }














    public static long[] operArray(java.util.function.LongConsumer operator, long[] arr, long init) {
        // your code and complete ... before operator
//		long[] test = Stream.of(arr).reduce(init, operator.accept(););

        return new long[]{};
    }



//		for (int i = 1; i < n; i++) {
//			List<Integer> temp = new ArrayList<>(){{add(1);}};
//			for (int x = 0; x < pascal.get(i).size() - 1; x++) {
//				temp.add(pascal.get(i).get(x) + pascal.get(i).get(x + 1));
//
//			}
//			temp.add(1);
//			pascal.add(temp);
//		}

//		BigInteger sum = BigInteger.valueOf(0);
//		for (int i = p; i <= n; i++) {
//			sum = sum.add(BigInteger.valueOf(pascal.get(i).get(p)));
//		}
//		return sum;
//	}


















    public static BigInteger[] findInitialNumbers(long divisor, long iterations) {

        BigInteger first = new BigInteger(String.valueOf(divisor));
        BigInteger second = first.multiply(BigInteger.valueOf(2));
        if (iterations-- == 0) {
            return new BigInteger[]{first, first};
        }





        // todo abs(first - second) > min(first, second)
        boolean flip = true;
        while (iterations-- > 0) {
            if (first.subtract(second).abs().compareTo(first.min(second)) > 0) {
                flip = !flip;
            }
            if (!flip) {
                second = second.add(first);
            } else {
                first = first.add(second);
            }
        }

        return new BigInteger[] { first, second };
    }
}







//todo ---------------------------------------------------------------------------------------------------------
// todo java -Xmx120m -Xms30m -Xmn10m -XX:PermSize=20m -XX:MaxPermSize=20m -XX:+UseSerialGC -jar Java2Demo.jar
//	public static boolean test(List<Integer> list, int number) {
//		return Math.pow(number, 2) == list.stream().map(e -> Math.pow(e, 2)).mapToLong(Double::longValue).sum() && list.size() == list.stream().distinct().toArray().length;
//	}

//	static void countKprimes(int k, int start, int end){
//		// Count prime factors of all numbers
//		// till B.
//		boolean prime[] = new boolean[end+1];
//		Arrays.fill(prime,true);
//		int p_factors[] = new int[end+1];
//		Arrays.fill(p_factors,0);
//
//		for (int p = 2; p <= end; p++)
//			if (p_factors[p] == 0)
//				for (int i = p; i <= end; i += p)
//					p_factors[i]++;
//
//		// Print all numbers with k prime factors
//		for (int i = start; i <= end; i++)
//			if (p_factors[i] == k)
//				System.out.print( i + " ");
//	}