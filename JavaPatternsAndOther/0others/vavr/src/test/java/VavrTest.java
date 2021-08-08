import io.vavr.Function0;
import io.vavr.Function1;
import io.vavr.Function2;
import io.vavr.Function5;
import io.vavr.Lazy;
import io.vavr.Tuple;
import io.vavr.Tuple2;
import io.vavr.Tuple3;
import io.vavr.collection.List;
import io.vavr.collection.Seq;
import io.vavr.control.Option;
import io.vavr.control.Try;
import io.vavr.control.Validation;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import java.util.Arrays;
import java.util.Collections;
import java.util.function.BiFunction;
import java.util.function.Function;

import static io.vavr.API.$;
import static io.vavr.API.Case;
import static io.vavr.API.Match;
import static io.vavr.API.run;
import static io.vavr.Predicates.isIn;
import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertNotNull;
import static org.junit.jupiter.api.Assertions.assertThrows;
import static org.junit.jupiter.api.Assertions.assertTrue;

class VavrTest {

	@Test
	void givenValue_whenShellcheckDeed_thenCorrect() {
		Object possibleNullObj = null;
		if (possibleNullObj == null) {
			possibleNullObj = "some text";
		}
		assertNotNull(possibleNullObj);
	}

	@Test
	void givenValue_whenShellcheckDeed_thenCorrect2() {
		Object possibleNullObj = null;
		assertThrows(NullPointerException.class, () -> possibleNullObj.toString());
	}

	@Test
	void givenValue_whenCreatesOption_thenCorrect() {
		Option<Integer> noneOption = Option.of(null);
		Option<Object> someOption = Option.of("val");

		assertEquals("None", noneOption.toString());
		assertEquals("Some(val)", someOption.toString());
	}

	@Test
	void givenNull_whenCreatesOption_thenCorrect() {
		String name = null;
		Option<String> nameOption = Option.of(name);
		assertEquals("wg", nameOption.getOrElse("wg"));
	}

	@Test
	void givenNonNull_whenCreatesOption_thenCorrect() {
		String name = "wojciech gaudnik";
		Option<String> nameOption = Option.of(name);
		assertEquals("wojciech gaudnik", nameOption.getOrElse("wg"));
	}

	@Test
	void whenCreatesTuple_thenCorrect1() {
		Tuple2<String, Integer> tuple2 = Tuple.of("Java", 8);
		String element1 = tuple2._1;
		int element2 = tuple2._2;

		assertEquals("Java", element1);
		assertEquals(8, element2);
	}

	@Test
	void whenCreatesTuple_thenCorrect2() {
		Tuple3<String, Integer, Long> tuple3 = Tuple.of("Java", 8, 2L);
		String element1 = tuple3._1;
		int element2 = tuple3._2;
		Long element3 = tuple3._3;

		assertEquals("Java", element1);
		assertEquals(8, element2);
		assertEquals(2L, element3);
	}

	@Test
	void givenBadCode_whenThrowsArithmetic_thanCorrect() {
		var test = new DivideByZero();
		assertThrows(ArithmeticException.class, test);

	}

	@Test
	void givenBadCode_whenTryHandles_thanCorrect() {
		Try<Integer> result = Try.of(() -> 1 / 0);
		assertFalse(result.isSuccess());
	}


	@Test
	void givenBadCode_whenTryHandles_thanCorrect2() {
		Try<Integer> result = Try.of(() -> 1 / 0);
		assertEquals(-1, result.getOrElse(-1));
	}

	@Test
	void givenJava8Function_whenWorks_thenCorrect() {
		Function<Integer, Integer> square = (num) -> num * num;
		int result = square.apply(2);

		assertEquals(4, result);
	}

	@Test
	void givenJava8BiFunction_whenWorks_thenCorrect() {
		BiFunction<Integer, Integer, Integer> sum =
				(num1, num2) -> num1 + num2;
		int result = sum.apply(5, 7);

		assertEquals(12, result);
	}

	@Test
	void givenVavrFunction_whenWorks_thenCorrect() {
		Function1<Integer, Integer> square = (num) -> num * num;
		int result = square.apply(2);

		assertEquals(4, result);
	}

	@Test
	void givenVavrBiFunction_whenWorks_thenCorrect() {
		Function2<Integer, Integer, Integer> sum =
				(num1, num2) -> num1 + num2;
		int result = sum.apply(5, 7);

		assertEquals(12, result);
	}

	@Test
	void whenCreatesFunction_thenCorrect0() {
		Function0<String> getClazzName = () -> this.getClass().getName();
		String clazzName = getClazzName.apply();

		assertEquals("VavrTest", clazzName);
	}

	@Test
	void whenCreatesFunction_thenCorrect5() {
		Function5<String, String, String, String, String, String> concat =
				(a, b, c, d, e) -> a + b + c + d + e;
		String finalString = concat.apply(
				"Hello ", "world", "! ", "Learn ", "Vavr");

		assertEquals("Hello world! Learn Vavr", finalString);
	}

	@Test
	void whenCreatesFunctionFromMethodRef_thenCorrect() {
		Function2<Integer, Integer, Integer> sum = Function2.of(this::sum);
		int summed = sum.apply(5, 6);

		assertEquals(11, summed);
	}

	@Test
	void whenImmutableCollectionThrows_thenCorrect() {
		java.util.List<String> wordList = Arrays.asList("abracadabra");
		java.util.List<String> list = Collections.unmodifiableList(wordList);
		assertThrows(UnsupportedOperationException.class, () -> list.add("boom"));
	}

	@Test
	void whenCreatesVavrList_thenCorrect() {
		List<Integer> intList = List.of(1, 2, 3);

		assertEquals(3, intList.length());
		assertEquals(new Integer(1), intList.get(0));
		assertEquals(new Integer(2), intList.get(1));
		assertEquals(new Integer(3), intList.get(2));
	}

	@Test
	void whenValidationWorks_thenCorrect() {
		PersonValidator personValidator = new PersonValidator();

		Validation<Seq<String>, Person> valid =
				personValidator.validatePerson("John Doe", 30);

		Validation<Seq<String>, Person> invalid =
				personValidator.validatePerson("John? Doe!4", -1);

		assertEquals(
				"Valid(Person(name=John Doe, age=30))",
				valid.toString());

		assertEquals("Invalid(List(Invalid characters in name: ?!4, Age must be at least 0))",
				invalid.toString());
	}

	@Test
	void givenFunction_whenEvaluatesWithLazy_thenCorrect() {
		Lazy<Double> lazy = Lazy.of(Math::random);
		assertFalse(lazy.isEvaluated());

		double val1 = lazy.get();
		assertTrue(lazy.isEvaluated());

		double val2 = lazy.get();
		assertEquals(val1, val2, 0.1);
	}

	@Test
	void whenIfWorksAsMatcher_thenCorrect() {
		int input = 3;
		String output;
		if (input == 0) {
			output = "zero";
		}
		if (input == 1) {
			output = "one";
		}
		if (input == 2) {
			output = "two";
		}
		if (input == 3) {
			output = "three";
		} else {
			output = "unknown";
		}

		assertEquals("three", output);
	}

	@Test
	void whenSwitchWorksAsMatcher_thenCorrect() {
		int input = 2;
		String output;
		switch (input) {
			case 0:
				output = "zero";
				break;
			case 1:
				output = "one";
				break;
			case 2:
				output = "two";
				break;
			case 3:
				output = "three";
				break;
			default:
				output = "unknown";
				break;
		}

		assertEquals("two", output);
	}

	@Test
	void whenMatchworks_thenCorrect() {
		int input = 2;
		String output = Match(input).of(
				Case($(1), "one"),
				Case($(2), "two"),
				Case($(3), "three"),
				Case($(), "?"));

		assertEquals("two", output);
		var arg = "--help";
		Match(arg).of(
				Case($(isIn("-h", "--help")), o -> run(this::displayHelp)),
				Case($(isIn("-v", "--version")), o -> run(this::displayVersion)),
				Case($(), o -> run(() -> {
					throw new IllegalArgumentException(arg);
				}))
		);
	}

	private void displayVersion() {
		System.out.println("display version");
	}

	private void displayHelp() {
		System.out.println("display help");
	}

	public int sum(int a, int b) {
		return a + b;
	}

	class DivideByZero implements Executable {
		@Override
		public void execute() throws Throwable {
			var i = 1 / 0;
		}
	}

}
