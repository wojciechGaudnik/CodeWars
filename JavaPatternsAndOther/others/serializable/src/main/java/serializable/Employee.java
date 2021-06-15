package serializable;

import java.io.Serializable;
import java.util.StringJoiner;

public class Employee implements Serializable {
	public String name;
	public String address;
	public transient int SSN;
	public int number;

	public void mailCheck() {
		System.out.println("Mailing a check to " + name + " " + address);
	}

	@Override
	public String toString() {
		return new StringJoiner(", ", Employee.class.getSimpleName() + "[", "]")
				.add("name='" + name + "'")
				.add("address='" + address + "'")
				.add("SSN=" + SSN)
				.add("number=" + number)
				.toString();
	}
}
