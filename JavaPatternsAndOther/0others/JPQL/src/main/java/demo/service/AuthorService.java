package demo.service;

import demo.model.Author;
import demo.model.projection.AuthorDTO;
import demo.model.repository.AuthorRepository;
import org.springframework.stereotype.Service;

import java.util.Collection;

@Service
public class AuthorService {

	private final AuthorRepository authorRepository;

	public AuthorService(AuthorRepository authorRepository) {
		this.authorRepository = authorRepository;
	}

	public Collection<Author> findAllAuthor(String name) {
		return authorRepository.findByFirstName(name);
	}

	public AuthorDTO findTest(Long addressId) {
		return authorRepository.findAllByAddressIdAndDataBorn(addressId);
	}
}
