/**
 * 
 */

using System.Drawing;

namespace candyshopProject
{
    public class statsComponent
    {


        private dbProvider myDbProvider;// ���� ��� �������� ������ �� �� ���������
        private Graphics myGraphics;

        public void Paint() // ���������� ���������, ����� ���������??
        {
            // ��������, � ���� ��������� �����  ����� ������� ��� �������?
            // ��������, ��� ����� �������������� ������ ����� myDbProvider

        }


        public statsComponent(dbProvider currentDbProvider) { // �����������
            //
            // ������� myGraphics
            myDbProvider = currentDbProvider;
        }



    }
}