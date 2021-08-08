package demo.controller;

import demo.model.Author;
import demo.model.projection.AuthorDTO;
import demo.service.AuthorService;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import java.util.Collection;

@RestController
public class AuthorController {

	AuthorService authorService;
	public AuthorController(AuthorService authorService) {
		this.authorService = authorService;
	}

	@GetMapping(value = "author")
	public Collection<Author> getAuthor() {
		return authorService.findAllAuthor("test");
	}

	@GetMapping(value = "test/{addressId}")
	public AuthorDTO getAuthorByAddressId(@PathVariable Long addressId) {
		return authorService.findTest(addressId);
	}
}
