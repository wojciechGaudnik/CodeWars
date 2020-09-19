package simple_web_framework_1_create_a_basic_router.kyu6

import org.junit.Test

class RouterTest{
    @Test
    void "Should handle GET routes" () {
        def router = new Router()
        router.with {
            bind("/hello", "GET", { -> "hello world" })
            bind("/login", "GET", { -> "Please log-in." })
            assert runRequest("/hello", "GET") == "hello world"
            assert runRequest("/login", "GET") == "Please log-in."
        }
    }

    @Test
    void "Should handle POST routes" () {
        def router = new Router()
        router.with {
            bind("/vote", "POST", { -> "Voted." })
            bind("/comment", "POST", { -> "Comment sent." })
            assert runRequest("/vote", "POST") == "Voted."
            assert runRequest("/comment", "POST") == "Comment sent."
        }
    }

    @Test
    void "Should handle mixed routes" () {
        def router = new Router()
        router.with {
            bind("/login", "GET", { -> "Please log-in." })
            bind("/login", "POST", { ->  "Logging-in." })

            assert runRequest("/login", "GET") == "Please log-in."
            assert runRequest("/login", "POST") == "Logging-in."
        }
    }

    @Test
    void "Should return 404 for non-existing routes" () {
        def router = new Router()
        assert router.runRequest("/this-url-does-not-exist", "GET") == "Error 404: Not Found"
    }

    @Test
    void "Should modify existing routes" () {
        def router = new Router()
        router.with {
            bind("/page", "GET", { -> "First binding." })
            bind("/page", "GET", { -> "Modified binding." })
            assert router.runRequest("/page", "GET") == "Modified binding."
        }
    }
}
