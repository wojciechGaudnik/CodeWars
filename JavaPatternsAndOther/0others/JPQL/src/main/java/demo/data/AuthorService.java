package demo.data;

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
}
