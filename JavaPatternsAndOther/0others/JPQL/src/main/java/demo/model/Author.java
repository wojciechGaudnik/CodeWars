package demo.model;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.MapKey;
import javax.persistence.OneToMany;
import javax.persistence.OrderBy;
import java.time.LocalDateTime;
import java.util.Map;

@Builder
@AllArgsConstructor
@NoArgsConstructor
@Data
@Entity
public class Author {

	@Id
	private Long id;

	private String firstName;

	private String lastName;

	private LocalDateTime born;

	@ManyToOne
	private Address address;

	@OneToMany(cascade = CascadeType.ALL)
	@MapKey(name = "id")
	private Map<Long, Book> books;


	@OneToMany(cascade = CascadeType.ALL)
	@MapKey(name = "id")
	@OrderBy("name")
	private Map<Long, Publisher> publishers;

	public Author(Long id, String firstName, String lastName) {
		this.id = id;
		this.firstName = firstName;
		this.lastName = lastName;
	}

}
