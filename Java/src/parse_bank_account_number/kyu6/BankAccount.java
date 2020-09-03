package parse_bank_account_number.kyu6;

import java.util.HashMap;

public class BankAccount {

	public static long parse(final String acctNbr) {

		var digitsDictionary = new HashMap<>();
		digitsDictionary.put(" _ | ||_|", "0");
		digitsDictionary.put("     |  |", "1");
		digitsDictionary.put(" _  _||_ ", "2");
		digitsDictionary.put(" _  _| _|", "3");
		digitsDictionary.put("   |_|  |", "4");
		digitsDictionary.put(" _ |_  _|", "5");
		digitsDictionary.put(" _ |_ |_|", "6");
		digitsDictionary.put(" _   |  |", "7");
		digitsDictionary.put(" _ |_||_|", "8");
		digitsDictionary.put(" _ |_| _|", "9");
		var acctutalNumber = acctNbr.split("\n");
		var topNumbers = acctutalNumber[0].split("(?<=\\G...)");
		var middleNumbers = acctutalNumber[1].split("(?<=\\G...)");
		var bottomNumbers = acctutalNumber[2].split("(?<=\\G...)");

		var number = new StringBuilder();
		for (var x = 0; x < topNumbers.length; x++) {
			number.append(digitsDictionary.get(topNumbers[x] + middleNumbers[x] + bottomNumbers[x]));
		}
		return Long.parseLong(String.valueOf(number));
	}
}
   
