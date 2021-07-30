public class Demo {
	public static void main(String[] args) {
		Department salesDepartment = new SalesDepartment(1, "Sales Department");
		Department financialDepartment = new FinancialDepartment(2, "Financial Department");
		HeadDepartment headDepartment = new HeadDepartment(3, "Head department");
		Department salesDepartment1 = new SalesDepartment(4, "Sales Department");
		Department financialDepartment1 = new FinancialDepartment(5, "Financial Department");
		HeadDepartment headDepartment1 = new HeadDepartment(6, "Head department");
		headDepartment1.addDepartment(salesDepartment1);
		headDepartment1.addDepartment(financialDepartment1);
		headDepartment.addDepartment(salesDepartment);
		headDepartment.addDepartment(financialDepartment);
		headDepartment.addDepartment(headDepartment1);
		headDepartment.printDepartmentName();
		System.out.println(System.getProperty("user.dir"));

	}
}
