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

    private byte[] ComputeHash(string pas) // вычисляем хэш для пароля
    {
        byte[] HashCode;
        // реализация есть, нужно вставить
        return HashCode;
    }


    public bool CheckUser(string username, string userpas) // аутентификация
    {
        bool accessIntoSubSystem = false;
        // вызов метода вычисления хэша, если совпадает со значением -> true
        return accessIntoSubSystem;
    }


    public authenticationComponent(dbProvider currentDbProvider) { // конструктор
        myDbProvider = currentDbProvider; // передаем ссылку на DbProvider, который соединен с БД
    }


}