package batman_quotes.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class BatmanQuotesTest {

	static String[] quotes = { "Quote Hidden in example test",
			"Holy haberdashery, Batman!",
			"Quote Hidden in example test"
	};

	@Test
	public void test1(){
		assertEquals("Fail", "Robin: Holy haberdashery, Batman!", BatmanQuotes.getQuote(quotes, "Rob1n"));
	}
}