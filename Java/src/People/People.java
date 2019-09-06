package People;

import lombok.Getter;
import lombok.Builder;
import lombok.Setter;


@Setter
@Getter
@Builder
public class People{
	private int age;
	private String name;
	private String lastName;
	private String city;
	private String job;

	private final String GREET="hello";

	public String greet(){
		return GREET+" my name is "+name;
	}

	public static void main(String[] args) {
		People people = People.builder().age(5).build();
		System.out.println(people.getAge());
		System.out.println(people.getName());
		System.out.println("Test");
	}
}
