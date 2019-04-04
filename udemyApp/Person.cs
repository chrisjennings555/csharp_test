using System;

namespace udemyApp
{
    class Person
    {
        private String name { get; set; }
        private int age { get; set; }
        private  String nickname { get; set; }

        public Person(String name, int age, String nickname)
        {
            this.name = name;
            this.age = age;
            this.nickname = nickname;
        }

        public String getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public String getNickname()
        {
            return this.nickname;
        }

    }
}

