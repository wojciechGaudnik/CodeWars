package decorator_by_spilca;

public class SMSSender implements NotificationSender{

	private final NotificationSender sender;

	public SMSSender(NotificationSender sender) {
		this.sender = sender;
	}

	@Override
	public void send() {
		if (sender != null) sender.send();
		System.out.println("Sending SMS notification");
	}
}