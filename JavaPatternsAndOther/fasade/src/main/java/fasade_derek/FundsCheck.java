package fasade_derek;

public class FundsCheck {

	private double cashInAccount = 1000.00;

	public double getCashInAccount() {
		return cashInAccount;
	}

	public void decrementCashInAccount(double cashWithdrawn) {
		cashInAccount -= cashWithdrawn;
	}

	public void increaseCashInAccount(double cashDeposit) {
		cashInAccount += cashDeposit;
	}

	public boolean haveEnoughCashInAccount(double cashToWithdrawn) {
		if (cashToWithdrawn > getCashInAccount()) {
			System.out.println("Error: You don't have enough money");
			System.out.println("CurrentBalance: " + getCashInAccount());
			return false;
		}
		decrementCashInAccount(cashToWithdrawn);
		System.out.println("Withdrawal Complete: Current Balance is " + getCashInAccount());
		return true;
	}

	public void makeDeposit(double cashToDeposit) {
		increaseCashInAccount(cashToDeposit);
		System.out.println("Deposit Complete: Current Balance is " + getCashInAccount());
	}
}
