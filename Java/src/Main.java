import java.util.Arrays;
import java.util.OptionalInt;
import java.util.stream.IntStream;

public class Main {

    public static void main(String[] args) {
        Object[] haystack1 = {"3", "123124234", null, "needle", "world", "hay", 2, "3", true, false};
        Object[] haystack2 = {"283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago"};
        Object[] haystack3 = {1,2,3,4,5,6,7,8,8,7,5,4,3,4,5,6,67,5,5,3,3,4,2,34,234,23,4,234,324,324,"needle",1,2,3,4,5,5,6,5,4,32,3,45,54};
//        assertEquals("found the needle at position 3", Kata.findNeedle(haystack1));
//        assertEquals("found the needle at position 5", Kata.findNeedle(haystack2));
//        assertEquals("found the needle at position 30", Kata.findNeedle(haystack3));

        System.out.println(findNeedle(haystack1));
        System.out.println(findNeedle(haystack2));
        System.out.println(findNeedle(haystack3));

    }

    public static String findNeedle(Object[] haystack) {
        OptionalInt index = IntStream.range(0, haystack.length).filter(i -> haystack[i] != null && haystack[i].equals("needle")).findFirst();
        return (index.isPresent()) ? "found the needle at position " + index.getAsInt() : "";
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