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

  
    public Guid ComputeHash(string pas) // вычисляем хэш для пароля
    {
        //переводим строку в байт-массим  
        byte[] bytes = Encoding.Unicode.GetBytes(pas);

        //создаем объект для получения средст шифрования  
        MD5CryptoServiceProvider CSP =
            new MD5CryptoServiceProvider();

        //вычисляем хеш-представление в байтах  
        byte[] byteHash = CSP.ComputeHash(bytes);

        string hash = string.Empty;

        //формируем одну цельную строку из массива  
        foreach (byte b in byteHash)
            hash += string.Format("{0:x2}", b);

        return new Guid(hash);
    }


    public bool CheckUser(string username, string userpas,string subsystem) // аутентификация
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


    public authenticationComponent(dbProvider currentDbProvider) { // конструктор
        myDbProvider = currentDbProvider; // передаем ссылку на DbProvider, который соединен с БД
    }


}