package demo.model.projection;


import java.util.Map;

public interface AuthorDTO {

	Long getId();
	String getFirstName();
	AddressDTO getAddress();

	Map<Long, PublisherDTO> getPublishers();
}
