package dev.gaudnik.no_now.SystemTime;

import java.time.ZonedDateTime;

public interface TimeProvider {

	ZonedDateTime provideCurrentZoneDateTime();

}
