using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class authenticationComponent {

    /**
     * 
     */
    private dbProvider myDbProvider;

    private byte[] ComputeHash(string pas) // ��������� ��� ��� ������
    {
        byte[] HashCode;
        // ���������� ����, ����� ��������
        return HashCode;
    }


    public bool CheckUser(string username, string userpas) // ��������������
    {
        bool accessIntoSubSystem = false;
        // ����� ������ ���������� ����, ���� ��������� �� ��������� -> true
        return accessIntoSubSystem;
    }


    public authenticationComponent(dbProvider currentDbProvider) { // �����������
        myDbProvider = currentDbProvider; // �������� ������ �� DbProvider, ������� �������� � ��
    }


}