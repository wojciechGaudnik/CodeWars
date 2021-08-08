package demo.bootstrap;

import demo.model.Address;
import demo.model.Author;
import demo.model.Book;
import demo.model.Publisher;
import demo.model.repository.AddressRepository;
import demo.model.repository.AuthorRepository;
import demo.model.repository.BookRepository;
import demo.model.repository.PublisherRepository;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import java.time.LocalDateTime;
import java.util.Arrays;
import java.util.Map;

@Component
public class Bootstrap implements CommandLineRunner {

	AuthorRepository authorRepository;

	AddressRepository addressRepository;

	BookRepository bookRepository;

	public Bootstrap(AuthorRepository authorRepository, AddressRepository addressRepository, BookRepository bookRepository, PublisherRepository publisherRepository) {
		this.authorRepository = authorRepository;
		this.addressRepository = addressRepository;
		this.bookRepository = bookRepository;
		this.publisherRepository = publisherRepository;
	}

	PublisherRepository publisherRepository;

	@Override
	public void run(String... args) throws Exception {
		var publisher1 = Publisher.builder().id(1L).name("publisher 1").build();
		var publisher2 = Publisher.builder().id(2L).name("publisher 2").build();
		var publisher3 = Publisher.builder().id(3L).name("publisher 3").build();

		var book1 = Book.builder().id(1L).name("book 1").build();
		var book2 = Book.builder().id(2L).name("book 2").build();
		var book3 = Book.builder().id(3L).name("book 3").build();

		var address1 = Address.builder().id(1L).street("street 1").build();
		var address2 = Address.builder().id(2L).street("street 2").build();
		var address3 = Address.builder().id(3L).street("street 3").build();

		publisherRepository.saveAll(Arrays.asList(publisher1, publisher2, publisher3));
		bookRepository.saveAll(Arrays.asList(book1, book2, book3));
		addressRepository.saveAll(Arrays.asList(address1, address2, address3));

		var author1 = Author.builder()
				.id(1L)
				.firstName("author 1")
				.lastName("last name 1")
				.born(LocalDateTime.of(2020, 1, 19, 12, 12))
				.address(address1)
				.books(Map.of(book1.getId(), book1, book2.getId(), book2, book3.getId(), book3))
				.publishers(Map.of(publisher1.getId(), publisher1, publisher2.getId(), publisher2))
				.build();

		authorRepository.save(author1);


	}
}
