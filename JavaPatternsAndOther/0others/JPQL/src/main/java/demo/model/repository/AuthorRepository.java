package demo.model.repository;

import demo.model.Author;
import demo.model.projection.AuthorDTO;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AuthorRepository extends JpaRepository<Author, Long> {

	@Query("FROM Author WHERE firstName = ?1")
	List<Author> findByFirstName(String firstName);

	@Query("SELECT a FROM Author a JOIN FETCH a.address JOIN FETCH a.publishers WHERE a.address.id = :addressId")
	AuthorDTO findAllByAddressIdAndDataBorn(
			@Param("addressId") Long addressId);
//			@Param("startDateTime") LocalDateTime startDateTime,
//			@Param("endDateTime") LocalDateTime endDateTime);
}
