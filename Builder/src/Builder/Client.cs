using System;

namespace Builder
{

    public class Client
    {
        public Client(Builder builder)
        {
            Builder =  builder;
        }

        public Builder Builder { get; }

        public Product Build()
        {
            Builder.BuildPartA();
            Builder.BuildPartB();
            return Builder.GetResult(); 
        }
    }
}
