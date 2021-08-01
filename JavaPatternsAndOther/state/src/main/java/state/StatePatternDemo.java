package state;

import state.state.StartState;
import state.state.StopState;

public class StatePatternDemo {
	public static void main(String[] args) {
		var context = new Context();
		var startState = new StartState();
		var stopState = new StopState();

		startState.doAction(context);
		System.out.println(context.getState().toString());
		stopState.doAction(context);
		System.out.println(context.getState().toString());
	}
}
