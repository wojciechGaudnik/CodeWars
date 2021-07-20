package fasade_derek;

public class BankAccountFacade {
	private int accountNumber;
	private int securityCode;
	AccountNumberCheck accountNumberCheck;
	SecurityCodeCheck codeChecker;
	FundsCheck fundsCheck;
	WelcomeToBank welcomeToBank;

	public BankAccountFacade(int accountNumber, int securityCode) {
		this.accountNumber = accountNumber;
		this.securityCode = securityCode;
		this.accountNumberCheck = new AccountNumberCheck();
		this.codeChecker = new SecurityCodeCheck();
		this.fundsCheck = new FundsCheck();
		this.welcomeToBank = new WelcomeToBank();
	}

	public int getAccountNumber() {
		return accountNumber;
	}

	public int getSecurityCode() {
		return securityCode;
	}

	public void withdrawCash(double amount) {
		if (accountNumberCheck.accountNumber(getAccountNumber()) && codeChecker.isSecurityCodeCorrect(getSecurityCode()) && fundsCheck.haveEnoughCashInAccount(amount)) {
			System.out.println("Transaction Complete");
		} else {
			System.out.println("Transaction Failed");
		}
	}
	public void depositCash(double amount) {
		if (accountNumberCheck.accountNumber(getAccountNumber()) && codeChecker.isSecurityCodeCorrect(getSecurityCode())) {
			fundsCheck.makeDeposit(amount);
			System.out.println("Transaction Complete");
		}
	}
}
