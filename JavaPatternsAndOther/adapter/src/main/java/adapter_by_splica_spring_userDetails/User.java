package adapter_by_splica_spring_userDetails;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class User {

	@Id
	private Long id;

	private String username;
	private String password;

	private String email;

	public String getPassword() {
		return password;
	}

	public String getUsername() {
		return username;
	}
}
