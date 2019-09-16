import java.util.stream.IntStream;

public class Main {

    public static void main(String[] args) {
        System.out.println("Congratulations! You're going to have a son." + chromosomeCheck("XY"));
        System.out.println("Congratulations! You're going to have a daughter." + chromosomeCheck("XX"));

    }

    public static String chromosomeCheck(String sperm) {
        System.out.println(sperm.contains("Y") + " <-------------");
        return (sperm.contains("Y"))?"Congratulations! You're going to have a son.":"Congratulations! You're going to have a daughter.";
        // Your code goes here. Have fun!
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