
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using candyshopProject;

/**
 * 
 */
public class stockSubsystem {

    /**
     * 
     */

    private frmStock myFormStock; // поле для хранения формы
    private dbProvider myDbProvider; // поле для БД коннектора
    private statsComponent myStatsComponent; // поле для компонента по отрисовке графиков

    public void ShowFrm() // показываем форму
    {
        // надо ли?
    }
    // еще методы???
    public stockSubsystem(dbProvider currentDbProvider) // конструктор
    {
        // создаем форму myFormStock
        // создаем myStatsComponent
        myDbProvider = currentDbProvider; // передаем ссылку на БД коннектор

    }






}