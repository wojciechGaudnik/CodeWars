package TripleSorter;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class TripleSorter {
	public static void main(String[] args) {
		List<Student> students = new ArrayList<>();
		students.add(new Student(23, 88, "David Goodman"));
		students.add(new Student(25, 82, "Mark Rose"));
		students.add(new Student(22, 90, "Jane Doe"));
		students.add(new Student(25, 90, "Jane Dane"));
		sort(students);
	}


	public static String sort(List<Student> students) {
		Comparator<Student> studentComparator = Comparator.comparing(Student::getGpa).reversed()
		                                    .thenComparing(student -> student.getFullName().split(" ")[1].charAt(0))
		                                    .thenComparing(Student::getAge);
		return students.stream().sorted(studentComparator).map(s -> s.getFullName()).collect(Collectors.joining(","));
	}
}
