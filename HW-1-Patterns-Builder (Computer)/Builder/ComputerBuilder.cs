using HW_1_Patterns_Builder__Computer_.Components;
using HW_1_Patterns_Builder__Computer_.Computer;
using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;
using System;
using System.Collections.Generic;

namespace HW_1_Patterns_Builder__Computer_.Builder
{
    public class ComputerBuilder : IBuilder
    {
        private MyComputer _computer = new MyComputer();

        private int Cost = 0;

        public ComputerBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._computer = new MyComputer();
            this.Cost = 0;
        }

        public void BuildLowConfiguration()
        {
            Processor pr = new Processor();
            MotherBoard mb = new MotherBoard();
            RAM ram = new RAM();
            HDD hdd = new HDD();
            VideoCard vc = new VideoCard();
            this._computer.Add(pr.LowConfiguration());
            this._computer.Add(mb.LowConfiguration());
            this._computer.Add(ram.LowConfiguration());
            this._computer.Add(hdd.LowConfiguration());
            this._computer.Add(vc.LowConfiguration());
            this.Cost = pr.Cost + mb.Cost + ram.Cost + hdd.Cost + vc.Cost;
        }

        public void BuildMiddleConfiguration()
        {
            Processor pr = new Processor();
            MotherBoard mb = new MotherBoard();
            RAM ram = new RAM();
            HDD hdd = new HDD();
            VideoCard vc = new VideoCard();
            this._computer.Add(pr.MiddleConfiguration());
            this._computer.Add(mb.MiddleConfiguration());
            this._computer.Add(ram.MiddleConfiguration());
            this._computer.Add(hdd.MiddleConfiguration());
            this._computer.Add(vc.MiddleConfiguration());
            this.Cost = pr.Cost + mb.Cost + ram.Cost + hdd.Cost + vc.Cost;
        }

        public void BuildHighConfiguration()
        {
            Processor pr = new Processor();
            MotherBoard mb = new MotherBoard();
            RAM ram = new RAM();
            HDD hdd = new HDD();
            VideoCard vc = new VideoCard();
            this._computer.Add(pr.HighConfiguration());
            this._computer.Add(mb.HighConfiguration());
            this._computer.Add(ram.HighConfiguration());
            this._computer.Add(hdd.HighConfiguration());
            this._computer.Add(vc.HighConfiguration());
            this.Cost = pr.Cost + mb.Cost + ram.Cost + hdd.Cost + vc.Cost;
        }

        public void BuildMyConfiguration()
        {
            BuildLowConfiguration();
            BuildMiddleConfiguration();
            BuildHighConfiguration();
            Console.WriteLine("Choose the components you want to add in your computer:\n");
            string[] componentsName = { "Processor", "MotherBoard", "RAM", "Storage", "VideoCard" };
            string choice = string.Empty;
            int choiceInt, iterator;
            List<ComponentBase> newList = new List<ComponentBase>();
            List<ComponentBase> myComputer = new List<ComponentBase>();
            for (int i=0; i< componentsName.Length; i++)
            {
                iterator = 0;
                Console.WriteLine($"\nSelect a {componentsName[i]} for your computer from the list below\n");
                foreach (var item in _computer.GetComponetsList())
                {
                    if (item.Component.Equals(componentsName[i]))
                    {
                        System.Console.WriteLine($"{iterator+1}. {item.ToString()}");
                        newList.Add(item);
                        iterator++;
                    }
                }
                Console.Write("\nInput a number component - ");
                do
                {
                    choiceInt = 0;
                    choice = Console.ReadLine();
                    Int32.TryParse(choice, out choiceInt);
                } while (choiceInt <= 0 || choiceInt > newList.Count);
                myComputer.Add(newList[choiceInt-1]);
                newList.Clear();
            }
            Reset();
            foreach (var item in myComputer)
                this._computer.Add(item);
        }

        public MyComputer GetComputer()
        {
            MyComputer result = this._computer;

            this.Reset();

            return result;
        }
    }
}
