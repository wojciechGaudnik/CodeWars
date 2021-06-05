package java_functional_programming_part_2_multiple_functions.kyu7;

import java.util.function.ToDoubleFunction;

public class FunctionalProgramming {

	public static ToDoubleFunction<Triangle> f = (t) -> {
		t.setArea(0.5 * t.base * t.height);
		return t.getArea();
	};
}

class Triangle {
	public final int height;
	public final int base;
	private double area;

	public Triangle(int height, int base) {
		this.height = height;
		this.base = base;
	}

	public void setArea(double a) {
		area = a;
	}
	public double getArea() {
		return area;
	}
}