package state.state;

import lombok.ToString;
import state.Context;
import state.State;

@ToString
public class StopState implements State {

	@Override
	public void doAction(Context context) {
		System.out.println("Player is in stop state");
		context.setState(this);
	}
}
