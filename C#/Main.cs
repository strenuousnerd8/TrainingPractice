﻿using System;
namespace Assignment
{
    // Client
    public class Client
    {
        public static void Main(string[] args)
        {
            T target = new A();
            target.fn1();
        }
    }

    // Target
    public class T
    {
        public virtual void fn1()
        {
            Console.WriteLine("Target fn1()");
        }
    }

    // Adapter
    public class A : T
    {
        private Ad adaptee = new Ad();
        public override void fn1()
        {
            adaptee.fn2();
        }
    }

    // Adaptee
    public class Ad
    {
        public void fn2()
        {
            Console.WriteLine("Adaptee fn2()");
        }
    }
}