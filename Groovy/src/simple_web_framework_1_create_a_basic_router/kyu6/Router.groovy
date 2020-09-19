package simple_web_framework_1_create_a_basic_router.kyu6

class Router {

    def routes = [:]

    void bind(String s1, String s2, Closure<String> stringClosure) {
        routes[s1+s2] = stringClosure.call()
    }

    String runRequest(String s1, String s2) {
        if (routes[s1 + s2]) {
            return routes[s1 + s2]
        }
        return "Error 404: Not Found"
    }
}
