
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

    private frmStock myFormStock; // ���� ��� �������� �����
    private dbProvider myDbProvider; // ���� ��� �� ����������
    private statsComponent myStatsComponent; // ���� ��� ���������� �� ��������� ��������

    public void ShowFrm() // ���������� �����
    {
        myFormStock.frmStock_Load(myDbProvider);
        myFormStock.ShowDialog();
        
    }
    // ��� ������???
    public stockSubsystem(dbProvider currentDbProvider) // �����������
    {
        // ������� ����� myFormStock
        // ������� myStatsComponent
        myDbProvider = currentDbProvider; // �������� ������ �� �� ���������
        myFormStock = new frmStock();

    }






}