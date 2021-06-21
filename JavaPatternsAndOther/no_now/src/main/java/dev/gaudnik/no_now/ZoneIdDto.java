package dev.gaudnik.no_now;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.ToString;

import java.time.ZoneId;

@Data
@ToString
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class ZoneIdDto {

	private ZoneId zoneId;

}
