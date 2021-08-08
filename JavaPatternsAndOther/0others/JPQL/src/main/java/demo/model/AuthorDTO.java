package demo.model;


import demo.model.repository.AddressDTO;

public interface AuthorDTO {

	Long getId();
	String getFirstName();
	AddressDTO getAddress();
}
