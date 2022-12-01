/*Надається скелет.
Ви допомагаєте своєму приятелю, який ще навчається на курсі «Основи ООП» - його звуть Пешослав (щоб не помилитися
з реальними людьми або тренерами). Він досить повільний і створив клас з усіма приватними членами. Ваші завдання полягають у
створити екземпляр об’єкта зі свого класу (завжди з початковим значенням 0), а потім викликати різні методи, які він має. ваш
обмеження полягає в тому, щоб нічого не змінювати в самому класі (вважати його чорним ящиком). Ви можете дивитися на його клас, але не дивіться
доторкнись до чого завгодно! Сам клас називається BlackBoxInt, він є оболонкою для примітиву int.
Методи цього класу:
• Add(int)
• Віднімання (ціле)
• Множення (ціле)
• Ділення (ціле)
• LeftShift(int)
• RightShift(int)
Введення
Вхідні дані складатимуться з рядків у формі:
<назва методу>_<значення>
Наприклад: Add_115
Введення завжди буде дійсним і в описаному форматі, тому немає потреби перевіряти його явно. Ви перестаєте отримувати
введення, коли ви зустрічаєте команду "END"*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(BlackBoxInteger);
            object blackBox = Activator.CreateInstance(type, true);
            while (true)
            {
                string[] str = Console.ReadLine().Split('_');
                if (str[0] != "End")
                {
                    string method = str[0];
                    object value = int.Parse(str[1]);
                    type.GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(blackBox, new[] { value });
                    Console.WriteLine(type.GetField("Value", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(blackBox));
                }
                else
                {
                    break;
                }
            }
        }
    }
}