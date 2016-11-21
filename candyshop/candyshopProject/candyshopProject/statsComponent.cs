/**
 * 
 */

using System.Drawing;

namespace candyshopProject
{
    public class statsComponent
    {


        private dbProvider myDbProvider;// поле дл€ хранени€ ссылки на Ѕƒ коннектор
        private Graphics myGraphics;

        public void Paint() // реализаци€ рисовани€, какие параметры??
        {
            // возможно, в виде параметра будет  также передан тип графика?
            // очевидно, что будет использоватьс€ запрос через myDbProvider

        }


        public statsComponent(dbProvider currentDbProvider) { // конструктор
            //
            // создаем myGraphics
            myDbProvider = currentDbProvider;
        }



    }
}