//package linked_lists_append.kyu7;
//
//import static org.junit.Assert.assertNull;
//
//import org.junit.Test;
//
//public class NodeTest {
//	@Test
//	public void twoEmpty() throws Exception {
//		assertNull( Node.append( null, null ) );
//	}
//
//	@Test
//	public void oneEmpty() throws Exception {
//		NodeHelper.assertEquals( Node.append( null, new Node( 1 ) ), new Node( 1 ) );
//		NodeHelper.assertEquals( Node.append( new Node( 1 ), null ), new Node( 1 ) );
//	}
//
//	@Test
//	public void oneOne() throws Exception {
//		NodeHelper.assertEquals( Node.append( new Node( 1 ), new Node( 2 ) ), NodeHelper.build( new int[] { 1, 2 } ) );
//		NodeHelper.assertEquals( Node.append( new Node( 2 ), new Node( 1 ) ), NodeHelper.build( new int[] { 2, 1 } ) );
//	}
//
//	@Test
//	public void bigLists() throws Exception {
//		NodeHelper.assertEquals(
//				Node.append( NodeHelper.build( new int[] { 1, 2 } ), NodeHelper.build( new int[] { 3, 4 } ) ),
//				NodeHelper.build( new int[] { 1, 2, 3, 4 } )
//		);
//		NodeHelper.assertEquals(
//				Node.append( NodeHelper.build( new int[] { 1, 2, 3, 4, 5 } ), NodeHelper.build( new int[] { 6, 7, 8 } ) ),
//				NodeHelper.build( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 } )
//		);
//	}
//}