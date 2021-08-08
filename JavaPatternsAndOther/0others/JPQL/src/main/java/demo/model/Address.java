package demo.model;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.Entity;
import javax.persistence.Id;

@Builder
@AllArgsConstructor
@NoArgsConstructor
@Data
@Entity
public class Address {

	@Id
	private Long id;

	private String street;
}
