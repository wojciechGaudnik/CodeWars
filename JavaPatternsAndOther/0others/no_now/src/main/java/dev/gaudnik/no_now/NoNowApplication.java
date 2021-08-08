package dev.gaudnik.no_now;

import dev.gaudnik.no_now.SystemTime.Registry;
import dev.gaudnik.no_now.SystemTime.RegistryInstance;
import dev.gaudnik.no_now.SystemTime.TimeProvider;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

import static com.google.common.base.Preconditions.checkNotNull;

@SpringBootApplication
public class NoNowApplication {

	public static void main(String[] args) {
//		initRegistry();
		SpringApplication.run(NoNowApplication.class, args);
	}

//	private static void initRegistry() {
//		final Registry registry = new Registry(SystemTimeProvider.INSTANCE);
//		RegistryInstance.initialise(registry);
//	}

	@Bean(autowireCandidate = false)
	Registry createRegistry(final TimeProvider timeProvider) {
		checkNotNull(timeProvider);
		final Registry registry = new Registry(timeProvider);
		RegistryInstance.initialise(registry);
		return registry;
	}
}
