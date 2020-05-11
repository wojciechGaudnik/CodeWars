namespace Katas
{
    public class kyu6FIXMEHello
    {
        private string name;
        private int age;
        private char sex;
        private int nameOrder;
        private int ageOrder;
        private int sexOrder;
        private int order;

        public kyu6FIXMEHello()
        {
        }

        public kyu6FIXMEHello SetAge(int age)
        {
            if (this.age == 0)
            {
                this.age = age;
                ageOrder = ++order;
                return this;
            }
            this.age = age;
            return this;
        }

        public kyu6FIXMEHello SetSex(char sex)
        {
            if (this.sex == 0)
            {
                this.sex = sex;
                sexOrder = ++order;
                return this;
            }
            this.sex = sex;
            return this;
        }

        public kyu6FIXMEHello SetName(string name)
        {
            if (this.name == null)
            {
                this.name = name;
                nameOrder = ++order;
                return this;
            }
            this.name = name;
            return this;
        }

        public string Hello()
        {
            var answer = new[] {"Hello. ", "", "", "",};
            if(nameOrder > 0) answer[nameOrder] = $"My name is {name}. ";
            if(ageOrder > 0) answer[ageOrder] = $"I am {age}. ";
            if(sexOrder > 0) answer[sexOrder] = $"I am {(sex == 'M' ? "male" : "female")}. ";
            return string.Join("", answer).Trim();
        }
    }
}