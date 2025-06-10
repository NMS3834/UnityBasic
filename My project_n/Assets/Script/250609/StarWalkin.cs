using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarWalkin : MonoBehaviour
{
    string star;


    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            star += "\n"; ; // �� �ٲ� �ݵ�� �߰��ؾ� Console ���� �� ����
        }

        Debug.Log(star);
    }


    public void Phase2()
    {
        star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            // ���� ���
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // �� ���
            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 1�ܰ�: �� ���� 1 ~ 5 ����
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        // 2�ܰ�: �� ���� 4 ~ 1 ����
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 1�ܰ�: �����ϴ� �ﰢ��
        for (int i = 1; i <= 5; i++)
        {
            // ���� ���
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // �� ���
            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        // 2�ܰ�: �����ϴ� �ﰢ��
        for (int i = 4; i >= 1; i--)
        {
            // ���� ���
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // �� ���
            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        int n = 5; // �� �� �� (������ ���� ���� �� ��)

        // 1�ܰ�: ���� �ﰢ�� (1~n��)
        for (int i = 1; i <= n; i++)
        {
            // ���� ���
            for (int j = 1; j <= n - i; j++)
            {
                star += " ";
            }

            // �� ��� (2*i - 1�� ���)
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        // 2�ܰ�: �Ʒ��� �ﰢ�� (n-1 ~ 1��)
        for (int i = n - 1; i >= 1; i--)
        {
            // ���� ���
            for (int j = 1; j <= n - i; j++)
            {
                star += " ";
            }

            // �� ��� (2*i - 1�� ���)
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        Debug.Log(star);
    }
}
