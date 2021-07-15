package adapter_by_splica.main;

import adapter_by_splica.library.LibraryNotificationSender;

public class AppNotificationSender implements NotificationSender{

	private final LibraryNotificationSender libraryNotificationSender;

	public AppNotificationSender(LibraryNotificationSender libraryNotificationSender) {
		this.libraryNotificationSender = libraryNotificationSender;
	}

	@Override
	public void sendNotification() {
		libraryNotificationSender.send();
	}


}
