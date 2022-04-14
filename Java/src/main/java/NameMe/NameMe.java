package NameMe;


public class NameMe {
	public String firstName;
	public String lastName;
	public String fullName;

	public NameMe(String first, String last) {
		this.firstName = first;
		this.lastName = last;
		this.fullName = firstName + " " + lastName;
	}

	public String getFullName() {
		return fullName;
	}

	public String getFirstName() {
		return firstName;
	}

	public String getLastName() {
		return lastName;
	}
}
