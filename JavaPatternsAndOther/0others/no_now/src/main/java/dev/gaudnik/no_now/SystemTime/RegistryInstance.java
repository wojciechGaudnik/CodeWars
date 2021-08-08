package dev.gaudnik.no_now.SystemTime;

import static com.google.common.base.Preconditions.checkNotNull;
import static com.google.common.base.Preconditions.checkState;

public class RegistryInstance {

	private static Registry registrySoleInstance;

	private RegistryInstance() {
		throw new UnsupportedOperationException();
	}

	public static void initialise(final Registry registry) {
		checkNotNull(registry);
		checkState(registrySoleInstance != null);
		registrySoleInstance = registry;
	}


	public static Registry provide() {
		return registrySoleInstance;
	}

}
