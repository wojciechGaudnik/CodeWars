package state.state;

import lombok.ToString;
import state.Context;
import state.State;

@ToString
public class StartState implements State {

	@Override
	public void doAction(Context context) {
		System.out.println("Player is in start state");
		context.setState(this);
	}

}
