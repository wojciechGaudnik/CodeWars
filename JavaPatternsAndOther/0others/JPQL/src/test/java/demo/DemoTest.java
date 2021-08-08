package demo;

import demo.data.Author;
import demo.data.AuthorRepository;
import lombok.extern.slf4j.Slf4j;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.orm.jpa.DataJpaTest;
import org.springframework.test.context.junit.jupiter.SpringExtension;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;


@Slf4j
@ExtendWith(SpringExtension.class)
@DataJpaTest
class DemoTest {

	@Autowired
	AuthorRepository authorRepository;

	@Test
	void test() {
		authorRepository.save(new Author(1L, "first Name", "last Name"));
		var name = authorRepository.findById(1L);
		assertThat(name.map(Author::getFirstName).orElse("")).isEqualTo("first Nam");

	}
}