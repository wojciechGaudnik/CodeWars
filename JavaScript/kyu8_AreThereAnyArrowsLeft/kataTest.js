test.assert_equals(any_arrows([]), False, "Should handle empty quiver")
test.assert_equals(any_arrows([{'range': 5}, {'range': 10, 'damaged': True}, {'damaged': True}]), True, "Should handle quiver with undamaged arrows")
test.assert_equals(any_arrows([{'range': 10, 'damaged': True}, {'damaged': True}]), False, "Should handle quiver with damaged arrows")