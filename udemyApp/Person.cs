using System;

namespace udemyApp
{
    class Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public  String nickname { get; set; }

          public Person(String name, int age, String nickname)
        {
            this.name = name;
            this.age = age;
            this.nickname = nickname;
        }


    }
}

