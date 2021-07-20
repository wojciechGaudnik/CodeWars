package fasade_derek;

public class BankAccount {
	public static void main(String[] args) {
		BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);

		accessingBank.withdrawCash(50.00);
		accessingBank.withdrawCash(900.00);
		accessingBank.depositCash(200.00);
	}
}
