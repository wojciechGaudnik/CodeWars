package versions_manager.kyu6;

import java.util.Arrays;
import java.util.Deque;
import java.util.LinkedList;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

class VersionManager {

	private int[] versionInts = new int[]{0, 0, 0};
	private static final int MAJOR = 0;
	private static final int MINOR = 1;
	private static final int PATCH = 2;
	private Deque<String> changes = new LinkedList<>();
	private String current = "";

	public VersionManager() {
		versionInts = new int[]{0, 0, 1};
		this.current = Arrays.stream(versionInts).boxed().map(Object::toString).collect(Collectors.joining("."));
	}

	public VersionManager(String version) throws ValidationException {
		var versionSplit = (version + ".0.0").split("\\.");
		if (versionSplit.length != 0 && !versionSplit[0].isEmpty()) {
			parseVersion(versionSplit);
		} else {
			versionInts = new int[]{0, 0, 1};
		}
		this.current = Arrays.stream(versionInts).boxed().map(Object::toString).collect(Collectors.joining("."));
	}

	private void parseVersion(String[] version) throws ValidationException {
		try {
			for (var i = 0; i < versionInts.length; i++) {
				versionInts[i] = Integer.parseInt(version[i]);
			}
		} catch (NumberFormatException e) {
			throw new ValidationException("Error occured while parsing version!");
		}
	}

	public String release() {
		return current;
	}

	public VersionManager major() throws ValidationException {
		changes.push(this.toString());
		versionInts[MAJOR] += 1;
		versionInts[MINOR] = 0;
		versionInts[PATCH] = 0;
		this.current = Arrays.stream(versionInts).boxed().map(Object::toString).collect(Collectors.joining("."));
		return this;
	}

	public VersionManager minor() throws ValidationException {
		changes.push(this.toString());
		versionInts[MINOR] += 1;
		versionInts[PATCH] = 0;
		this.current = Arrays.stream(versionInts).boxed().map(Object::toString).collect(Collectors.joining("."));
		return this;

	}

	public VersionManager patch() {
		changes.push(this.toString());
		versionInts[PATCH] += 1;
		this.current = Arrays.stream(versionInts).boxed().map(Object::toString).collect(Collectors.joining("."));
		return this;
	}


	public VersionManager rollback() throws RollbackException {
		try {
			this.current = changes.pop();
			var currentSeparate = this.current.split("\\.");
			for (var i = 0; i < currentSeparate.length; i++) {
				versionInts[i] = Integer.parseInt(currentSeparate[i]);
			}
			return this;
		} catch (NoSuchElementException e) {
			throw new RollbackException("Cannot rollback!");
		}
	}

	private static class ValidationException extends Exception {
		public ValidationException(String message) {
			super(message);
		}
	}

	private static class RollbackException extends Exception {
		public RollbackException(String message) {
			super(message);
		}
	}

	@Override
	public String toString() {
		return this.release();
	}
}
