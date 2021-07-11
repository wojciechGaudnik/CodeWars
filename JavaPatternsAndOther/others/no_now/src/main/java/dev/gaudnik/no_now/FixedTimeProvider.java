package dev.gaudnik.no_now;

import dev.gaudnik.no_now.SystemTime.TimeProvider;

import java.time.ZonedDateTime;

import static com.google.common.base.Preconditions.checkNotNull;

public class FixedTimeProvider implements TimeProvider {

	private ZonedDateTime currentZonedDateTime;

	public FixedTimeProvider(ZonedDateTime zonedDateTime) {
		checkNotNull(zonedDateTime);
		this.currentZonedDateTime = zonedDateTime;
	}

	@Override
	public ZonedDateTime provideCurrentZoneDateTime() {
		return currentZonedDateTime;
	}

	public void updateCurrentZoneDateTime(final ZonedDateTime newZonedDateTime) {
		checkNotNull(newZonedDateTime);
		this.currentZonedDateTime = newZonedDateTime;
	}
}
