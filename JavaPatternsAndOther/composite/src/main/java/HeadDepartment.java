import java.util.ArrayList;
import java.util.Collection;

public class HeadDepartment implements Department {

	private Integer id;
	private String name;
	private Collection<Department> childrenDepartments;

	public HeadDepartment(Integer id, String name) {
		this.id = id;
		this.name = name;
		childrenDepartments = new ArrayList<Department>();
	}

	@Override
	public void printDepartmentName() {
		System.out.println(id + " " + getClass().getSimpleName());
		childrenDepartments.forEach(Department::printDepartmentName);
	}

	public void addDepartment(Department department) {
		childrenDepartments.add(department);
	}

	public void removeDepartment(Department department) {
		childrenDepartments.remove(department);
	}
}