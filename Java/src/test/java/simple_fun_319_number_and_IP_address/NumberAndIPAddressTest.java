package simple_fun_319_number_and_IP_address;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class NumberAndIPAddressTest {
	@Test
	public void numberAndIPaddress() throws Exception {
		assertEquals( "167773121", NumberAndIPAddress.numberAndIPaddress( "10.0.3.193" ) );
		assertEquals( "10.3.3.193", NumberAndIPAddress.numberAndIPaddress( "167969729" ) );
	}
}