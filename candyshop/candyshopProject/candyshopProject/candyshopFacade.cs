
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class candyshopFacade {

    /**
     * 
     */
    private dbProvider CurrentDbProvider;// поле для БД коннектора

    public dbProvider PropDbProvider // cвойство для доступа
    {
        get { return CurrentDbProvider; }
        set { value = CurrentDbProvider; }
    }
    
    private shopSubsystem myShopSubsystem; 

    public shopSubsystem PropShopSubsystem // cвойство для доступа
    {
        get { return myShopSubsystem; }
        set { value = myShopSubsystem; }
    }
    private stockSubsystem myStockSubsystem;
    public stockSubsystem PropStockSubsystem // cвойство для доступа
    {
        get { return myStockSubsystem; }
        set { value = myStockSubsystem; }
    }

    public candyshopFacade() { // конструктор
        // вызываем конструкторы: PropDbProvider,myShopSubsystem,myStockSubsystem
    }

    public void destroyCandyshop() // деструктор
    {
        // убиваем объекты
    }



}