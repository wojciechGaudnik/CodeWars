package basic_calculator.kyu7;

public class Calculator {

	public static Double calculate(final double numberOne, final String operation, final double numberTwo) {
		switch (operation) {
			case "+":
				return numberOne + numberTwo;
			case "-":
				return numberOne - numberTwo;
			case "*":
				return (numberOne == 0 || numberTwo == 0) ? 0 : numberOne * numberTwo;
			case "/":
				return (numberTwo != 0) ? numberOne / numberTwo : null;
		}
		return null;
	}
}
