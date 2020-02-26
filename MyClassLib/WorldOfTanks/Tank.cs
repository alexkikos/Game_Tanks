using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        string name_tank;
        int ammunition;
        int armor;
        int mobiliti;//про тип данных полей не указано, решил сделать инт, но омгут быть дабл


      
        public string GetAmmunition()
        {
            return ammunition.ToString();
        }
        public string GetName()
        {
            return name_tank;
        }
        public string GetArmor()
        {
            return armor.ToString();
        }
        public string GetMobiliti()
        {
            return mobiliti.ToString();
        }
        public string Name_tank { get => name_tank; }//сеттеры не делал, тк указано что из значения задаются только в конструкторе, а значит тут только чтение!
        public int Ammunition { get => ammunition;  }
        public int Armor { get => armor; }
        public int Mobiliti { get => mobiliti;  }



        /// <summary>
        /// Оператор возвращает  1 победа т2,  0 победа т,  -1 ничья
        /// </summary>
        /// <param name="t2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int operator * (Tank t2, Tank t)
        {
            int params1 = t2.Ammunition + t2.Armor + t2.Mobiliti;
            int params2 = t.Ammunition + t.Armor + t.Mobiliti;
            try
            {
                if (params1 > params2) return 1;
                else if (params1 == params2) throw new Exception("Ох, мы словили одинаковые параметры танков!");//теория вероятности в деле,можно было и без исключения, но задание было промоделировать исключения, поэтому подключил их
                else return 0;
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                return -1;
            }
        
        }

        /// <summary>
        /// Иницилизируем все поля рандомно, кроме имени Танка, его указываем в мейне
        /// </summary>
        /// <param name="name_tank"></param>
        public Tank(string name_tank)//тк поля амуниции задаю рандом, тут присваиваю только имя
        {
            Random rand = new Random();
            this.name_tank = name_tank;
            this.ammunition = rand.Next(1, 100);
            this.armor = rand.Next(1, 100);
            this.mobiliti = rand.Next(1, 100);
        }
    }
}
