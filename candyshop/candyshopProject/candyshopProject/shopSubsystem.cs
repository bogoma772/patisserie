
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


    private frmShop myFormShop; // ���� ��� �������� �����
    private dbProvider myDbProvider; // ���� ��� �� ����������

    public void ShowFrm() // ���������� �����
    {
        // ���� ��?
    }

    public shopSubsystem(dbProvider currentDbProvider) { // �����������
        // ������� ����� myFormShop
        myDbProvider = currentDbProvider; // �������� ������ �� �� ���������
    }




}