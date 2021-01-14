package greet_me.kyu7;

public class GreetMe {

	public static void main(String[] args) {
		System.out.println(greet("ala"));
	}
	public static String greet(String name){
		return "Hello " + Character.toUpperCase(name.charAt(0)) + name.substring(1).toLowerCase() + "!";
	}
}
   
