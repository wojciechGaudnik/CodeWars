package dev.gaudnik.no_now.SystemTime;

import org.springframework.stereotype.Component;

import java.time.ZonedDateTime;

@Component
public class SystemTimeProvider implements TimeProvider {

	public static final SystemTimeProvider INSTANCE = new SystemTimeProvider();

	private SystemTimeProvider() {}

	@Override
	public ZonedDateTime provideCurrentZoneDateTime() {
		return ZonedDateTime.now();
	}

}
