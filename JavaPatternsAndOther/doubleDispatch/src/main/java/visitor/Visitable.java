package visitor;

public interface Visitable <V>{
	void accept(V visitor);
}
