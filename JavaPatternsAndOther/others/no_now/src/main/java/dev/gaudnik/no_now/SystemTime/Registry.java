package dev.gaudnik.no_now.SystemTime;

import static com.google.common.base.Preconditions.checkNotNull;

public class Registry {

	private final TimeProvider timeProvider;

	public Registry(final TimeProvider timeProvider) {
		checkNotNull(timeProvider);
		this.timeProvider = timeProvider;
	}

	public TimeProvider provideTimeProvider() {
		return timeProvider;
	}
}
