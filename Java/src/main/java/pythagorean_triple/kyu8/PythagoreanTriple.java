package pythagorean_triple.kyu8;

public class PythagoreanTriple {
	public int pythagoreanTriple(int[] triple){
		return (Math.pow(triple[0], 2) + Math.pow(triple[1], 2) == Math.pow(triple[2], 2))?1:0;
	}

}
