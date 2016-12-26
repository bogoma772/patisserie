
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
    private dbProvider CurrentDbProvider;// ���� ��� �� ����������

    public dbProvider PropDbProvider // c������� ��� �������
    {
        get { return CurrentDbProvider; }
        set { value = CurrentDbProvider; }
    }
    
    private shopSubsystem myShopSubsystem;

    public authenticationComponent myAuthComp;

    public shopSubsystem PropShopSubsystem // c������� ��� �������
    {
        get { return myShopSubsystem; }
        set { value = myShopSubsystem; }
    }
    private stockSubsystem myStockSubsystem;
    public stockSubsystem PropStockSubsystem // c������� ��� �������
    {
        get { return myStockSubsystem; }
        set { value = myStockSubsystem; }
    }

    public candyshopFacade() { // �����������
        // �������� ������������: PropDbProvider,myShopSubsystem,myStockSubsystem
        CurrentDbProvider = new dbProvider();
        myShopSubsystem = new shopSubsystem(CurrentDbProvider);
        myStockSubsystem = new stockSubsystem(CurrentDbProvider);
        myAuthComp = new authenticationComponent(CurrentDbProvider);

        
    }

    public void destroyCandyshop() // ����������
    {
        // ������� �������
    }



}