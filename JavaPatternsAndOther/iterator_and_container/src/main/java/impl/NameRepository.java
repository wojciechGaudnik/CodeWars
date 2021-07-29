package impl;

import container.Container;
import iterator.Iterator;

public class NameRepository implements Container {

	public String[] names = {"ala", "ela", "ola", "mol"};

	@Override
	public Iterator getIterator() {
		return new NameIterator();
	}

	private class NameIterator implements Iterator {

		int index = 0;

		@Override
		public boolean hasNext() {
			return index < names.length;
		}

		@Override
		public Object next() {
			if (hasNext()) {
				return names[index++];
			}
			return null;
		}
	}
}
