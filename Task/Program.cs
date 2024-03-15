using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Computer> computersList = new List<Computer>()
            {
                new Computer(){ CompID = 1, CompName = "Origin", CompCPU = "i7", CompCPUclockspeed = 4700, CompRamSize = 32, CompHDDsize = 1000, CompGPUvram = 12, CompPrice = 1500, CompQuantity = 15 },
                new Computer(){ CompID = 2, CompName = "NZXT", CompCPU = "ryzen5", CompCPUclockspeed = 4000, CompRamSize = 15, CompHDDsize = 500, CompGPUvram = 8, CompPrice = 950, CompQuantity = 23 },
                new Computer(){ CompID = 3, CompName = "MacPRO", CompCPU = "m2", CompCPUclockspeed = 3500, CompRamSize = 64, CompHDDsize = 1000, CompGPUvram = 64, CompPrice = 3999.99, CompQuantity = 5},
                new Computer(){ CompID = 4, CompName = "StarForge", CompCPU = "i9", CompCPUclockspeed = 6000, CompRamSize = 128, CompHDDsize = 4000, CompGPUvram = 24, CompPrice = 4599.99, CompQuantity = 4 },
                new Computer(){ CompID = 5, CompName = "IronForge", CompCPU = "i7", CompCPUclockspeed = 4500, CompRamSize = 64, CompHDDsize = 1000, CompGPUvram = 16, CompPrice = 1999.99, CompQuantity = 8 },
                new Computer(){ CompID = 6, CompName = "StarForge", CompCPU = "i5", CompCPUclockspeed = 3500, CompRamSize = 16, CompHDDsize = 1000, CompGPUvram = 8, CompPrice = 1049.99, CompQuantity = 26 },
                new Computer(){ CompID = 7, CompName = "Dell", CompCPU = "i3", CompCPUclockspeed = 3700, CompRamSize = 16, CompHDDsize = 500, CompGPUvram = 4, CompPrice = 599.9, CompQuantity = 40 },
                new Computer(){ CompID = 8, CompName = "Origin", CompCPU = "ryzen7", CompCPUclockspeed = 4500, CompRamSize = 32, CompHDDsize = 2000, CompGPUvram = 12, CompPrice = 1700, CompQuantity = 10 }
            };

            Console.Write("Выберите название процессора i9/i7/i5/i3/m2/ryzen5/ryzen7 :");
            string cpuName = Console.ReadLine();
            List<Computer> computers1 = computersList
                .Where(d => d.CompCPU == cpuName)
                .ToList();
            Print(computers1);

            Console.Write("Введите минимальный обьем ОЗУ в ГБ:");
            int cpuRAM = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = (from d in computersList
                                         where d.CompRamSize >= cpuRAM
                                         select d).ToList();
            Print(computers2);

            Console.WriteLine("_____________вывести весь список, отсортированный по увеличению стоимости____________");
            List<Computer> computers3 = computersList
                .OrderBy(d => d.CompPrice)
                .ToList();
            Print(computers3);

            Console.WriteLine("_____________ вывести весь список, сгруппированный по типу процессора____________");
            IEnumerable<IGrouping<string, Computer>> computers4 = computersList.GroupBy(d => d.CompCPU).ToList();
            foreach(IGrouping<string, Computer> gr in computers4) {
                Console.WriteLine(gr.Key);
                foreach(Computer c in gr) {
                    Console.WriteLine($"ID={c.CompID,-1} Name={c.CompName,-9} CPU={c.CompCPU,-6} Clocks={c.CompCPUclockspeed,-4}MHz RAM={c.CompRamSize,-3}GB MemSpace={c.CompHDDsize,-5}GB VRAM={c.CompGPUvram,-2}GB Price={c.CompPrice,-7} Quantity={c.CompQuantity,-2}pcs");
                }
            }
            Console.WriteLine();
            Console.WriteLine("_____________найти самый дорогой и самый бюджетный компьютер____________");
            Computer computers51 = computersList
                .OrderByDescending(d => d.CompPrice)
                .FirstOrDefault();
            Computer computers52 = computersList
                .OrderBy(d => d.CompPrice)
                .FirstOrDefault();
            List<Computer> computers5 = new List<Computer>() {
            computers51,
            computers52
            };
            Print(computers5);
            Console.WriteLine("_____________есть ли хотя бы один компьютер в количестве не менее 30 штук____________");
            if(computersList.Any(d => d.CompQuantity >= 30)) {
                Console.WriteLine("Присутсвует");
            }
            else {
                Console.WriteLine("Отсутсвует");
            }



            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach(Computer c in computers) {
                Console.WriteLine($"ID={c.CompID,-1} Name={c.CompName,-9} CPU={c.CompCPU,-6} Clocks={c.CompCPUclockspeed,-4}MHz RAM={c.CompRamSize,-3}GB MemSpace={c.CompHDDsize,-5}GB VRAM={c.CompGPUvram,-2}GB Price={c.CompPrice,-7} Quantity={c.CompQuantity,-2}pcs");
            }
            Console.WriteLine();
        }
    }
}
