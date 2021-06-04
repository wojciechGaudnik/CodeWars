package java_functional_programming_part_1_the_beginning.kyu7;


import java.util.function.Function;

public class FunctionalProgramming {
	public static Function<Student, Boolean> f = s -> "John Smith".equals(s.getFullName()) && "js123".equals(s.studentNumber);

}
