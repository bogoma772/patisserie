
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
    }

    public void destroyCandyshop() // ����������
    {
        // ������� �������
    }



}