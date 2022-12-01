/*Вам надається клас RichSoilLand із великою кількістю полів (подивіться на наданий скелет). Як хороший фермер, як ти
є, ви повинні їх зібрати. Збирання означає, що ви повинні надрукувати кожне поле в певному форматі (див. вихідні дані).
Введення
Ви отримаєте максимум 100 рядків за допомогою однієї з наступних команд:
• private - вивести всі приватні поля
• protected - роздрукувати всі захищені поля
• public - друкує всі публічні поля
• all - вивести ВСІ оголошені поля
• ЖНИВА - завершити введення
Вихід
Для кожної команди ви повинні надрукувати поля, які мають заданий модифікатор доступу, як описано в розділі введення.
Формат, у якому слід друкувати поля, такий:
"<модифікатор доступу> <тип поля> <назва поля>"*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(HarvestingFields);
            while (true)
            {
                string str = Console.ReadLine();
                IEnumerable<FieldInfo> fields;
                if (str == "public")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
                }
                else if (str == "protected")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(field => field.IsFamily);
                }
                else if (str == "private")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(field => field.IsPrivate);
                }
                else if (str == "all")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                }
                else
                {
                    break;
                }
                foreach (var fieldInfo in fields)
                {
                    string dostup = fieldInfo.Attributes.ToString().ToLower();
                    if (dostup == "family")
                        dostup = "protected";
                    Console.WriteLine(dostup + " " + fieldInfo.FieldType.Name + " " + fieldInfo.Name);
                }
            }
        }
    }
}