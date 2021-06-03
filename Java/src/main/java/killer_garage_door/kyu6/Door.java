package killer_garage_door.kyu6;

import java.util.HashMap;
import java.util.Iterator;
import java.util.stream.Collectors;

public class Door {

	public static String run(String events) {
		System.out.println(events);
		var killerDoor = KillerDoor.of(events);
		killerDoor.run();
		return killerDoor.getLevelsDuringEvents();
	}

	static class KillerDoor {


		private enum EVENTS {NO_EVENT, PRESSED, OBSTACLE}
        private enum SATES {OPEN, MOVING_UP, MOVING_DOWN, CLOSED, PAUSED}

		private SATES  state;
		private int level;
		private Iterator<EVENTS> events;
		private StringBuilder histogramLevels;
		private SATES lastState;

		private KillerDoor(){}

		public KillerDoor(Iterator<EVENTS> translatedEvents) {
			state = SATES.CLOSED;
			level = 0;
			events = translatedEvents;
			histogramLevels = new StringBuilder();
		}

		public static KillerDoor of(String events) {
			return new KillerDoor(translatedEvents(events));
		}

		private static Iterator<EVENTS> translatedEvents(String events) {
			var mapEvents = new HashMap<Character, EVENTS>();
			mapEvents.put('P', EVENTS.PRESSED);
			mapEvents.put('O', EVENTS.OBSTACLE);
			mapEvents.put('.', EVENTS.NO_EVENT);
			return events.chars().mapToObj(c -> (char) c).map(mapEvents::get).collect(Collectors.toList()).iterator();
		}

		public void run() {
			while (events.hasNext()) {
				var event = events.next();
				switch (event) {
					case PRESSED:
						pressButton();
						break;
					case OBSTACLE:
						obstacleDeleted();
						break;
					case NO_EVENT:
						break;
				}
				nextCycle();
			}
		}

		private void nextCycle() {
			if (state == SATES.MOVING_DOWN) {
				moveDown();
			} else if (state == SATES.MOVING_UP) {
				moveUp();
			}
			histogramLevels.append(level);
		}

		private void obstacleDeleted() {
			switch (this.state) {
				case MOVING_UP:
					this.state = SATES.MOVING_DOWN;
					break;
				case MOVING_DOWN:
					this.state = SATES.MOVING_UP;
					break;
				default:
					throw new IllegalStateException();
			}
		}

		private void pressButton() {
			switch (this.state) {
				case OPEN:
					this.state = SATES.MOVING_DOWN;
					break;
				case CLOSED:
					this.state = SATES.MOVING_UP;
					break;
				case PAUSED:
					this.state = this.lastState;
					this.lastState = SATES.PAUSED;
					break;
				case MOVING_DOWN:
				case MOVING_UP:
					this.lastState = this.state;
					this.state = SATES.PAUSED;
					break;
				default:
					throw new IllegalStateException();
			}
		}

		private void moveUp() {
			if (level < 5) {
				level++;
			} else {
				state = SATES.OPEN;
			}
		}

		private void moveDown() {
			if (level > 0) {
				level--;
			} else {
				state = SATES.CLOSED;
			}
		}

		public String getLevelsDuringEvents() {
			if (events.hasNext())
				throw new IllegalStateException();
			return histogramLevels.toString();
		}
	}
}