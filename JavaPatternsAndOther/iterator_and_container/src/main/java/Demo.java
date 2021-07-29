import impl.NameRepository;
import iterator.Iterator;

public class Demo {
	public static void main(String[] args) {
		var nameRepository = new NameRepository();

		for (Iterator it = nameRepository.getIterator(); it.hasNext(); ) {
			System.out.println("Name : " + it.next() );
		}
	}
}
