package columnize.kyu6;

import static org.junit.Assert.*;

import org.junit.jupiter.api.Test;

		import static org.assertj.core.api.Assertions.assertThat;

class KataSampleTest {

	@Test
	void shouldHandleSingleColumn() {

		String[] input = { "1", "12", "123", "1234", "12345", "123456" };
		var expected = "1     \n"
				+ "12    \n"
				+ "123   \n"
				+ "1234  \n"
				+ "12345 \n"
				+ "123456";
		var actual = Kata.columnize(input, 1);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleMultipleColumns() {

		String[] input = { "1", "12", "123", "1234", "12345", "123456" };
		var expected = "1    | 12    | 123   \n"
				+ "1234 | 12345 | 123456";
		var actual = Kata.columnize(input, 3);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleUnevenColumns() {

		String[] input = { "1", "12", "123", "1234", "12345", "123457" };
		var expected = "1      | 12 | 123 | 1234 | 12345\n"
				+ "123457";
		var actual = Kata.columnize(input, 5);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleMoreColumnsThanInput() {

		String[] input = { "1", "12", "123", "1234", "12345", "123456" };
		var expected = "1 | 12 | 123 | 1234 | 12345 | 123456";
		var actual = Kata.columnize(input, 999);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleEmptyStrings() {

		String[] input = { "", "12", "123", "", "12345", "" };
		var expected = "      | 12\n"
				+ "123   |   \n"
				+ "12345 |   ";
		var actual = Kata.columnize(input, 2);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleEmptyColumns() {

		String[] input = { "", "", "", ""};
		var expected = " | \n"
				+ " | ";
		var actual = Kata.columnize(input, 2);
		assertThat(actual).isEqualTo(expected);
	}

	@Test
	void shouldHandleWhitespace() {

		String[] input = { "1          ", "12", "123", "1234", "12345", "      " };
		var expected = "1           | 12    \n"
				+ "123         | 1234  \n"
				+ "12345       |       ";
		var actual = Kata.columnize(input, 2);
		assertThat(actual).isEqualTo(expected);
	}
}