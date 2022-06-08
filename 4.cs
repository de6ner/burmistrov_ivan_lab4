/*using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;



namespace lab4
{
    public class Garden
    {
        List<Tree> gardenList = new List<Tree>();

        public Garden(params Tree[] arr)
        {
            foreach (var item in arr)
            {
                gardenList.Add(item);
            }
        }

        public void showGarden()
        {
            foreach (var item in gardenList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void sortTreesByFruitWeight()
        {
            Console.WriteLine("List of trees before sorting\n\n");
            foreach (Tree tree in gardenList)
            {
                Console.WriteLine(tree.ToString());
            }

            gardenList.Sort();

            Console.WriteLine("\n\nList of trees after sorting\n\n");
            foreach (Tree tree in gardenList)
            {
                Console.WriteLine(tree.ToString());
            }
        }

        public void transplantAllNeededTrees()
        {
            Console.WriteLine("List of trees before transplant\n\n");
            foreach (var tree in gardenList)
            {
                Console.WriteLine(tree.ToString());
            }
            Console.WriteLine("\n\nList of trees after transplant\n\n");

            List<Tree> anotherList = new List<Tree>();

            foreach (var tree in gardenList)
            {
                if (!tree.doesNeedTransplant())
                {
                    anotherList.Add(tree);
                }
            }

            gardenList = anotherList;

            foreach (var tree in anotherList)
            {
                Console.WriteLine(tree.ToString());
            }
        }
    }

    public abstract class Tree : IComparable<Tree>
    {
        abstract public int getFruitWeight();
        abstract public void showType();
        abstract public bool doesNeedTransplant();
        public int CompareTo(Tree other)
        {
            if (this.getFruitWeight() > other.getFruitWeight())
            {
                return 1;
            }
            else if (this.getFruitWeight() < other.getFruitWeight())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }

    public class Apple : Tree
    {
        static int numberOfTrees = 0;
        static int totalFruitWeight = 0;

        private int numberOfTree = 0;
        private int age = 0;
        private int fruitWeight = 0;
        public override int getFruitWeight()
        {
            return fruitWeight;
        }
        public int getAge { get { return age; } set { age = value; } }
        public int getNumberOfTree { get { return numberOfTree; } }
        public int getTotalNumberOfTrees { get { return numberOfTrees; } }
        public int getTotalFruitWeight { get => totalFruitWeight; }
        public Apple(int fruitWeight, int age)
        {
            this.fruitWeight = fruitWeight;
            this.age = age;
            numberOfTrees++;
            numberOfTree = numberOfTrees;
            totalFruitWeight += fruitWeight;
        }
        ~Apple()
        {
            numberOfTrees--;
            totalFruitWeight -= this.fruitWeight;
        }
        private string type = "Apple";
        public override void showType()
        {
            Console.WriteLine(type);
        }
        public override bool doesNeedTransplant()
        {
            if (this.age > 10 || (this.fruitWeight < 15 && this.age >= 5))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string toReturn = "Type of tree: " + type + " Number of tree: " + this.numberOfTree + " Age: " + this.age + " Fruit weight: " + this.fruitWeight;
            return toReturn;
        }
    }

    public class Cherry : Tree
    {
        static int numberOfTrees = 0;
        static int totalFruitWeight = 0;

        private int numberOfTree = 0;
        private int age = 0;
        private int fruitWeight = 0;
        public override int getFruitWeight()
        {
            return fruitWeight;
        }
        public int getAge { get { return age; } set { age = value; } }
        public int getNumberOfTree { get { return numberOfTree; } }
        public int getTotalNumberOfTrees { get { return numberOfTrees; } }
        public int getTotalFruitWeight { get => totalFruitWeight; }
        public Cherry(int fruitWeight, int age)
        {
            this.fruitWeight = fruitWeight;
            this.age = age;
            numberOfTrees++;
            numberOfTree = numberOfTrees;
            totalFruitWeight += fruitWeight;
        }
        ~Cherry()
        {
            numberOfTrees--;
            totalFruitWeight -= this.fruitWeight;
        }
        private string type = "Cherry";
        public override void showType()
        {
            Console.WriteLine(type);
        }
        public override bool doesNeedTransplant()
        {
            if (this.age > 10 || (this.fruitWeight < 15 && this.age >= 5))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string toReturn = "Type of tree: " + type + " Number of tree: " + this.numberOfTree + " Age: " + this.age + " Fruit weight: " + this.fruitWeight;
            return toReturn;
        }
    }

    public class Grape : Tree
    {
        static int numberOfTrees = 0;
        static int totalFruitWeight = 0;

        private int numberOfTree = 0;
        private int age = 0;
        private int fruitWeight = 0;
        public override int getFruitWeight()
        {
            return fruitWeight;
        }
        public int getAge { get { return age; } set { age = value; } }
        public int getNumberOfTree { get { return numberOfTree; } }
        public int getTotalNumberOfTrees { get { return numberOfTrees; } }
        public int getTotalFruitWeight { get => totalFruitWeight; }
        public Grape(int fruitWeight, int age)
        {
            this.fruitWeight = fruitWeight;
            this.age = age;
            numberOfTrees++;
            numberOfTree = numberOfTrees;
            totalFruitWeight += fruitWeight;
        }
        ~Grape()
        {
            numberOfTrees--;
            totalFruitWeight -= this.fruitWeight;
        }
        private string type = "Grape";
        public override void showType()
        {
            Console.WriteLine(type);
        }
        public override bool doesNeedTransplant()
        {
            if (this.age > 10 || (this.fruitWeight < 15 && this.age >= 5))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string toReturn = "Type of tree: " + type + " Number of tree: " + this.numberOfTree + " Age: " + this.age + " Fruit weight: " + this.fruitWeight;
            return toReturn;
        }
    }

    public class Pear : Tree
    {
        static int numberOfTrees = 0;
        static int totalFruitWeight = 0;

        private int numberOfTree = 0;
        private int age = 0;
        private int fruitWeight = 0;
        public override int getFruitWeight()
        {
            return fruitWeight;
        }
        public int getAge { get { return age; } set { age = value; } }
        public int getNumberOfTree { get { return numberOfTree; } }
        public int getTotalNumberOfTrees { get { return numberOfTrees; } }
        public int getTotalFruitWeight { get => totalFruitWeight; }
        public Pear(int fruitWeight, int age)
        {
            this.fruitWeight = fruitWeight;
            this.age = age;
            numberOfTrees++;
            numberOfTree = numberOfTrees;
            totalFruitWeight += fruitWeight;
        }
        ~Pear()
        {
            numberOfTrees--;
            totalFruitWeight -= this.fruitWeight;
        }
        private string type = "Pear";
        public override void showType()
        {
            Console.WriteLine(type);
        }
        public override bool doesNeedTransplant()
        {
            if (this.age > 10 || (this.fruitWeight < 15 && this.age >= 5))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string toReturn = "Type of tree: " + type + " Number of tree: " + this.numberOfTree + " Age: " + this.age + " Fruit weight: " + this.fruitWeight;
            return toReturn;
        }
    }

    public class Orange : Tree
    {
        static int numberOfTrees = 0;
        static int totalFruitWeight = 0;

        private int numberOfTree = 0;
        private int age = 0;
        private int fruitWeight = 0;
        public override int getFruitWeight()
        {
            return fruitWeight;
        }
        public int getAge { get { return age; } set { age = value; } }
        public int getNumberOfTree { get { return numberOfTree; } }
        public int getTotalNumberOfTrees { get { return numberOfTrees; } }
        public int getTotalFruitWeight { get => totalFruitWeight; }
        public Orange(int fruitWeight, int age)
        {
            this.fruitWeight = fruitWeight;
            this.age = age;
            numberOfTrees++;
            numberOfTree = numberOfTrees;
            totalFruitWeight += fruitWeight;
        }
        ~Orange()
        {
            numberOfTrees--;
            totalFruitWeight -= this.fruitWeight;
        }
        private string type = "Orange";
        public override void showType()
        {
            Console.WriteLine(type);
        }
        public override bool doesNeedTransplant()
        {
            if (this.age > 10 || (this.fruitWeight < 15 && this.age >= 5))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string toReturn = "Type of tree: " + type + " Number of tree: " + this.numberOfTree + " Age: " + this.age + " Fruit weight: " + this.fruitWeight;
            return toReturn;
        }
    }


    static class Programm
    {
        static void Main()
        {
            *//*Apple appleTree1 = new Apple(30, 5);
            Apple appleTree2 = new Apple(45, 7);
            Apple appleTree3 = new Apple(50, 9);

            Cherry cherryTree1 = new Cherry(20, 3);
            Cherry cherryTree2 = new Cherry(25, 5);
            Cherry cherryTree3 = new Cherry(15, 7);

            Grape grapeTree1 = new Grape(15, 3);
            Grape grapeTree2 = new Grape(20, 5);
            Grape grapeTree3 = new Grape(10, 7);

            Pear pearTree1 = new Pear(15, 3);
            Pear pearTree2 = new Pear(20, 5);
            Pear pearTree3 = new Pear(35, 7);

            Orange orangeTree1 = new Orange(1, 5);
            Orange orangeTree2 = new Orange(2, 7);
            Orange orangeTree3 = new Orange(3, 9);*//*



            Garden garden = new Garden(new Apple(50, 5), new Cherry(23, 3), new Grape(16, 3), new Pear(5, 7), new Orange(1, 1), new Apple(20, 3), new Apple(36, 4), new Apple(5, 8));
            //garden.showGarden();
            garden.transplantAllNeededTrees();



        }
    }
}*/