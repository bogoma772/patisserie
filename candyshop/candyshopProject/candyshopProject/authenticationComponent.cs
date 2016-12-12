using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

/**
 * 
 */
public class authenticationComponent {

    /**
     * 
     */
    private dbProvider myDbProvider;

  
    public Guid ComputeHash(string pas) // ��������� ��� ��� ������
    {
        //��������� ������ � ����-������  
        byte[] bytes = Encoding.Unicode.GetBytes(pas);

        //������� ������ ��� ��������� ������ ����������  
        MD5CryptoServiceProvider CSP =
            new MD5CryptoServiceProvider();

        //��������� ���-������������� � ������  
        byte[] byteHash = CSP.ComputeHash(bytes);

        string hash = string.Empty;

        //��������� ���� ������� ������ �� �������  
        foreach (byte b in byteHash)
            hash += string.Format("{0:x2}", b);

        return new Guid(hash);
    }


    public bool CheckUser(string username, string userpas,string subsystem) // ��������������
    {
        bool accessIntoSubSystem = false;
        string sqlQuery = "select password from " + subsystem + " where name = " + '\u0022' + username+ '\u0022';
        string pasFromBase = myDbProvider.ReadOneValueFromDB(sqlQuery);
        if (ComputeHash(userpas) == ComputeHash(pasFromBase))
        {
            accessIntoSubSystem = true;
        }
        else
        {
            accessIntoSubSystem = false;
        }
        return accessIntoSubSystem;
    }


    public authenticationComponent(dbProvider currentDbProvider) { // �����������
        myDbProvider = currentDbProvider; // �������� ������ �� DbProvider, ������� �������� � ��
    }


}