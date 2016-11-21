
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using candyshopProject;

/**
 * 
 */
public class shopSubsystem
{


    private frmShop myFormShop; // поле для хранения формы
    private dbProvider myDbProvider; // поле для БД коннектора

    public void ShowFrm() // показываем форму
    {
        // надо ли?
    }

    public shopSubsystem(dbProvider currentDbProvider) { // конструктор
        // создаем форму myFormShop
        myDbProvider = currentDbProvider; // передаем ссылку на БД коннектор
    }




}