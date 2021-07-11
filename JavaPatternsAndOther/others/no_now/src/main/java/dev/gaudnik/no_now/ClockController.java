package dev.gaudnik.no_now;

import lombok.extern.slf4j.Slf4j;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import java.time.ZoneId;
import java.time.ZonedDateTime;

@Slf4j
@RestController
public class ClockController {

	public static void main(String[] args) {
		System.out.println("test");
	}

	@GetMapping("/current_time")
	public String getTime() {
		return ZonedDateTime.now().toString();
	}

	@PostMapping("/current_time_in")
	public String getTimeIn(@RequestBody ZoneIdDto zoneId) {
		log.debug(String.valueOf(zoneId));
		log.debug(String.valueOf(zoneId.getZoneId()));
		log.debug(String.valueOf(zoneId));
		return String.valueOf(ZonedDateTime.now((zoneId.getZoneId())));
	}

	@GetMapping("/zoneId")
	public ZoneIdDto getZoneId() {
		return ZoneIdDto.builder().zoneId(ZoneId.systemDefault()).build();
	}

	@GetMapping("/allZoneIds")
	public String getAllZoneIds() {
		return String.valueOf(ZoneId.getAvailableZoneIds());
	}
}
