var Singleton = function(){
    if (Singleton._instance){
        return Singleton._instance
    }
    Singleton._instance = this;

    function getInstance(){
        return Singleton._instance || new Singleton();
    }
};
