package serializable;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Demo {
	public static void main(String[] args) throws IOException {
		var employee = new Employee();
		employee.name = "Rey";
		employee.address = "al. 666";
		employee.SSN = 12341234;
		employee.number = 666999;

		try (var fileOut = new FileOutputStream("employee.ser")) {
			ObjectOutputStream out = new ObjectOutputStream(fileOut);
			out.writeObject(employee);
			out.close();
		}
		System.out.println("Saved");

		Employee employeeDeserialized = null;
		try (var fileIn = new FileInputStream("employee.ser")) {
			var in = new ObjectInputStream(fileIn);
			employeeDeserialized = (Employee) in.readObject();

		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		System.out.println(employeeDeserialized);

	}
}
