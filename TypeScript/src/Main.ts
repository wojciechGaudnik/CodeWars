export class Main{
    private readonly str: string;

    constructor(name: string) {
        this.str = name
    }

    main(){
       console.log(this.str)
        return this.str;
    }
}

const test = new Main("Hello");
test.main()