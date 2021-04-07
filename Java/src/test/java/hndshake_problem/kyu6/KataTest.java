package hndshake_problem.kyu6;

import org.junit.Assert;
import org.junit.Test;

public class KataTest {
	@Test
	public void SampleTest()
	{
		Assert.assertEquals(1, Kata.GetParticipants(0));
		Assert.assertEquals(2, Kata.GetParticipants(1));
		Assert.assertEquals(3, Kata.GetParticipants(3));
		Assert.assertEquals(4, Kata.GetParticipants(6));
		Assert.assertEquals(5, Kata.GetParticipants(7));
	}
}