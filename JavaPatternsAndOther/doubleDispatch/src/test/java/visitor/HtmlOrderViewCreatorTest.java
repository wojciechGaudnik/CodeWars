package visitor;

import double_dispatch.Order;
import double_dispatch.SpecialOrder;
import org.junit.jupiter.api.Test;
import single.dispatch.OrderFixtureUtils;
import single.dispatch.OrderLine;

import java.util.Arrays;
import java.util.List;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

class HtmlOrderViewCreatorTest {

	@Test
	void test() throws Exception {
		// given
		List<OrderLine> anyOrderLines = OrderFixtureUtils.anyOrderLines();
		List<Order> orders = Arrays.asList(new Order(anyOrderLines), new SpecialOrder(anyOrderLines));
		HtmlOrderViewCreator htmlOrderViewCreator = new HtmlOrderViewCreator();

		// when
		orders.get(0).accept(htmlOrderViewCreator);
		String regularOrderHtml = htmlOrderViewCreator.getHtml();
		orders.get(1).accept(htmlOrderViewCreator);
		String specialOrderHtml = htmlOrderViewCreator.getHtml();

		// then
		assertThat(regularOrderHtml).containsPattern("<p>Regular order total cost: .*</p>");
		assertThat(specialOrderHtml).containsPattern("<h1>Special Order</h1><p>total cost: .*</p>");
	}
}