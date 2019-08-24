
public class Main {

    public static void main(String[] args) {
        byte a = 1;
        byte b = 2;
        System.out.println(sum(a , b));


    }
    public static byte sum (byte a, byte b) {
        byte c = (byte) (a + b);
        return c;
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