﻿using System;
using FactoryPattern;
using AbstructFactoryPattern;
using BuilderPattern;

namespace Design.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //工厂方法模式
            //FactoryPatternMethods(); 

            //抽象工厂模式
            //AbstructFactoryPatternMethods();

            //建造者模式
            BuilderPatternMethods();

            Console.ReadKey();
        }

        /// <summary>
        /// 工厂方法模式
        /// </summary>
        public static void FactoryPatternMethods()
        {
            var apple = FruitFactory.CreateInstance("Apple");
            var banana = FruitFactory.CreateInstance("Banana");
            Console.WriteLine($"苹果单价是：{apple.GetPrice()}");
            Console.WriteLine($"香蕉单价是：{banana.GetPrice()}");
        }

        /// <summary>
        /// 抽象工厂模式
        /// </summary>
        public static void AbstructFactoryPatternMethods()
        {
            // 北京工厂
            var bjFactory = AbstructFruitFactory.GetFactory("BJ");
            var bjApple = bjFactory.GetApple();
            Console.WriteLine($"北京苹果的单价：{bjApple.GetPrice()}，包装形状：{bjApple.GetPackageShape()}");
            var bjBanana = bjFactory.GetBanana();
            Console.WriteLine($"北京香蕉的单价：{bjBanana.GetPrice()}，包装形状：{bjBanana.GetPackageShape()}");

            // 广州工厂
            var gzFactory = AbstructFruitFactory.GetFactory("GZ");
            var gzApple = gzFactory.GetApple();
            Console.WriteLine($"广州苹果的单价：{gzApple.GetPrice()}，包装形状：{gzApple.GetPackageShape()}");
            var gzBanana = gzFactory.GetBanana();
            Console.WriteLine($"广州香蕉的单价：{gzBanana.GetPrice()}， 包装形状：{gzBanana.GetPackageShape()}");
        }

        /// <summary>
        /// 建造者模式
        /// </summary>
        public static void BuilderPatternMethods()
        {
            var director = new Director();

            var bjBuilder = new BJBuilder();
            director.Construct(bjBuilder);
            bjBuilder.GetCake().Show();

            var gzBuilder = new GZBuilder();
            director.Construct(gzBuilder);
            gzBuilder.GetCake().Show();
        }
    }
}
