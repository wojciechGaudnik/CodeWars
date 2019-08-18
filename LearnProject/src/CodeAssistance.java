class CodeFormatDemo{

    final static int a_const = 10000;
    final static int b_const = 500;


public static void calc(){InnerCalc.process(a_const, b_const); }

    static class InnerCalc{

final static int some_const = 124136; public static int process(int a, int b){ return  a * b + some_const;
        }
    }

}