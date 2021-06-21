package dev.gaudnik.no_now;

import dev.gaudnik.no_now.SystemTime.Registry;
import dev.gaudnik.no_now.SystemTime.RegistryInstance;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

import java.time.ZoneId;
import java.time.ZonedDateTime;

@SpringBootTest
class NoNowApplicationTests {

	private static final ZonedDateTime CURRENT_ZONED_DATE_TIME = ZonedDateTime.of(2021, 5, 20, 18, 30, 0, 0, ZoneId.systemDefault());

	private FixedTimeProvider fixedTimeProvider;

	@Test
	void contextLoads() {
	}

	@BeforeEach
	private void beforeEach() {
		fixedTimeProvider = new FixedTimeProvider(CURRENT_ZONED_DATE_TIME);
		final Registry registry = new Registry(fixedTimeProvider);
		RegistryInstance.initialise(registry);
	}
}
