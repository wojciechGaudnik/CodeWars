package decorator_by_spilca;

public class Main {

	public static void main(String[] args) {
		NotificationSender emailSender = new EmailSender(new SMSSender(null));
		emailSender.send();
	}
}
