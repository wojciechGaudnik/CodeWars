package consumer;

import java.util.StringJoiner;

public class Duck {
	private String name;
	private Integer size;

	public Duck(String name, Integer size) {
		this.name = name;
		this.size = size;
	}

	public Integer getSize() {
		return size;
	}

	public void setSize(Integer size) {
		this.size = size;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public static boolean test(String duck, Duck duckObj) {
		return duckObj.name.equals(duck);
	}
	@Override
	public String toString() {
		return new StringJoiner(", ", Duck.class.getSimpleName() + "[", "]")
				.add("name='" + name + "'")
				.add("size=" + size)
				.toString();
	}

}
