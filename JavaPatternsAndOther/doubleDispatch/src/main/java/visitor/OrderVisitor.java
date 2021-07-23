package visitor;

import double_dispatch.Order;
import double_dispatch.SpecialOrder;

public interface OrderVisitor {

	void visit(Order order);

	void visit(SpecialOrder order);
}
