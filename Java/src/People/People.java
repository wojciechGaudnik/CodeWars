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
}
