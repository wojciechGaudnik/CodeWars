package fFusion_chamber_shutdown.kyu7;

import org.assertj.core.api.SoftAssertions;
import org.junit.jupiter.api.Test;

import java.util.stream.IntStream;

class FusionChamberShutdownTest {
	@Test
	public void fixedTests() {
		SoftAssertions softly = new SoftAssertions();
		int[][] params = new int[][]{
				{45, 11, 100, 5, 45, 0},
				{354, 1023230, 0, 0, 0, 354},
				{939, 3, 694, 1, 346, 0},
				{215, 41, 82100, 20, 215, 0},
				{113, 0, 52, 0, 26, 0}
		};
		IntStream.range(0, params.length).forEach(i -> {
			int[] caseParams = params[i];
			softly.assertThat(FusionChamberShutdown.burner(caseParams[0], caseParams[1], caseParams[2]))
					.as(String.format("burner(%s, %s, %s)", caseParams[0], caseParams[1], caseParams[2]))
					.containsExactly(caseParams[3], caseParams[4], caseParams[5]);
		});
		softly.assertAll();
	}
}