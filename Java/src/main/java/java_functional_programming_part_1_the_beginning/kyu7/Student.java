package java_functional_programming_part_1_the_beginning.kyu7;

public class Student {
	private final String firstName;
	private final String lastName;
	public final String studentNumber;

	public Student(String firstName, String lastName, String studentNumber) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.studentNumber = studentNumber;
	}

	public String getFullName() {
		return firstName + " " + lastName;
	}

	public String getCommaName() {
		return lastName + ", " + firstName;
	}
}
