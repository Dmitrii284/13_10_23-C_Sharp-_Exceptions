﻿
/*
 Exception
throw - В С# оператор throw используется для генерации исключений. Исключения представляют собой ошибки,
которые могут возникнуть во время выполнения программы и помешать ее нормальному функционированию.

Синтаксис оператора throw выглядит следующим образом:

throw new Exception(“Сообщение об ошибке”);
Здесь Exception - это класс, который представляет собой базовую класс для всех исключений в C#.
Вы можете использовать любой другой класс исключений, наследуемый от Exception.

В сообщении об ошибке можно указать любую информацию, которая поможет разработчику понять причину возникшей ошибки.

Исключения могут быть обработаны с помощью блоков try-catch-finally. Блок try выполняется до тех пор,
пока не возникнет исключение. Если исключение возникает, управление передается в блок catch, где можно обработать

//////////////
finally
 в C# используется для выполнения блока кода,
который должен быть выполнен независимо от того,
было ли выброшено исключение в блоке try или нет. 
Он гарантирует, что код будет выполнен, даже если в блоке try произошла ошибка. 
Например:
try
{
    // some code here
}
catch (Exception ex)
{
    // handle the exception
}
finally
{
    // this code will always be executed
}
////////////

 */
/*
 Task2

ТЕМА: НАСЛЕДОВАНИЕ. ИНТЕРФЕЙСЫ
Цель: Закрепить у слушателей практические навыки и теоретические знания для работы классами и объектами, свойствами. 
Научиться создавать иерархии классов.
Необходимые инструменты: MS Visual Studio 2016.
Документация: Конспект, Литература.
Ориентировочное время исполнения: 2 часа.
Требования к отчету: Отчет должен быть оформлен в виде 
электронного документа — программный код с комментариями, выводы о результатах выполняемых действий и копии экрана.
Размер файла отчета до 2 МБ со скриншотами.
Реализовать в С# пояснить как работает. 
Задание 1. Реализовать программу “Строительство дома”
Реализовать:
Классы
■ House (Дом), Basement (Фундамент), Walls (Стены), 
Door (Дверь), Window (Окно), Roof (Крыша); 
■ Team (Бригада строителей), Worker (Строитель), 
TeamLeader (Бригадир).
Интерфейсы
■ IWorker, IPart.
Все части дома должны реализовать интерфейс IPart
(Часть дома), для рабочих и бригадира предоставляется 
базовый интерфейс IWorker (Рабочий)
 
Бригада строителей (Team) строит дом (House). Дом 
состоит из фундамента (Basement), стен (Wall), окон 
(Window), дверей (Door), крыши (Part).
Согласно проекту, в доме должно быть 1 фундамент, 
Бригада начинает работу, и строители последовательно 
“строят” дом, начиная с фундамента. Каждый строитель 
не знает заранее, на чём завершился предыдущий этап 
строительства, поэтому он “проверяет”, что уже построено и продолжает работу. 
Если в игру вступает бригадир 
(TeamLeader), он не строит, а формирует отчёт, что уже 
построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что 
строительство дома завершено и отображается “рисунок 
дома” (вариант отображения выбрать самостоятельно)
 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

Книга VLR Via C# - Книга про сишарп (Как он работает под капотом)

\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

 */

namespace _13_10_23_C_Sharp__Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //try
            //{

            //}
            //catch {Exception ex }
            //{
            //    ex.Massege;// Сообщение об исключении
            //    ex.Source;// хранит имя объекта или сборки, которое вызвало исключение
            //    ex.StackTrece;// Возвращает строковое исключение
            //    throw;//используется для генерации исключений.
            // throw new exception("Не подходит.");
            //}
            //finally // Он гарантирует, что код будет выполнен, даже если в блоке try произошла ошибка. 
            //{
            //}

            Console.WriteLine("Какие объекты построены:");

            House house = new House();
            House house1 = house;
            house.Build();
            Console.ReadLine();

        }
    }
}