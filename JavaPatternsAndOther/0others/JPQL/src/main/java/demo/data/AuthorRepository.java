package demo.data;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AuthorRepository extends JpaRepository<Author, Long> {

	@Query("FROM Author WHERE firstName = ?1")
	List<Author> findByFirstName(String firstName);
}
