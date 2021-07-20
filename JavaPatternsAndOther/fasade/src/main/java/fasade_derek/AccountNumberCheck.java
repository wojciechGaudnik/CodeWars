package fasade_derek;

public class AccountNumberCheck {

	private int accountNumber = 12345678;

	public int getAccountNumber() {
		return accountNumber;
	}

	public boolean accountNumber(int accountNumberToCheck) {
		if (accountNumberToCheck == getAccountNumber()) {
			return true;
		}
		return false;
	}

}
