package fasade_derek;

public class SecurityCodeCheck {

	private int securityCode = 1234;

	public int getSecurityCode() {
		return securityCode;
	}

	public boolean isSecurityCodeCorrect(int securityCodeToCheck) {
		if (securityCodeToCheck == getSecurityCode()) {
			return true;
		}
		return false;
	}
}
