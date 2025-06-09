using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    List<string> topGrade = new List<string>();
    List<string> secondGrade = new List<string>();
    List<string> normalGrade = new List<string>();

    int totalDrawCount = 0; // ��ü ���� �̱� Ƚ��

    // Start is called before the first frame update
    void Start()
    {
        topGrade.Add("�����þ�");
        topGrade.Add("�ɺ�");

        secondGrade.Add("�����Ͼ�");
        secondGrade.Add("����");
        secondGrade.Add("������");
        secondGrade.Add("Į�Ľ�");

        normalGrade.Add("��");
        normalGrade.Add("�����");
        normalGrade.Add("�ڽ���");
        normalGrade.Add("����콺");
        normalGrade.Add("�׸�����");
        normalGrade.Add("ȭ");
        normalGrade.Add("�Ǹ��� �ʸ���");

        // Start()������ ���� �ڵ����� ������ ����!
        // ��ư Ŭ�� �� TenDraw()�� ����ǵ��� ����
    }

    // public ���� �ٲ�� Button���� ȣ�� ����
    public void TenDraw()
    {
        List<string> drawResults = new List<string>();

        totalDrawCount += 10;

        string guaranteedSecondGrade = GetRandomCharacter(secondGrade);
        drawResults.Add(guaranteedSecondGrade);

        for (int i = 0; i < 9; i++)
        {
            string character = RandomDraw();
            drawResults.Add(character);
        }

        // 80���� õ�� �ߵ�
        if (totalDrawCount >= 80)
        {
            Debug.Log("80���� õ�� �ߵ�! �ְ� ��� Ȯ�� ����");
            string topCharacter = GetRandomCharacter(topGrade);
            drawResults[0] = topCharacter; // ù��° �̱� �ڸ��� �ְ� ��� ���� ����
            totalDrawCount = 0; // õ�� �ʱ�ȭ
        }

        // ��� ���
        Debug.Log("===== 10���� ��� =====");
        for (int i = 0; i < drawResults.Count; i++)
        {
            Debug.Log($"�̱� {i + 1}: {drawResults[i]}");
        }
    }

    string RandomDraw()
    {
        float rand = UnityEngine.Random.Range(0f, 100f);

        if (rand < 1f)
        {
            return GetRandomCharacter(topGrade);
        }
        else if (rand < 10f)
        {
            return GetRandomCharacter(secondGrade);
        }
        else
        {
            return GetRandomCharacter(normalGrade);
        }
    }

    string GetRandomCharacter(List<string> gradeList)
    {
        int index = UnityEngine.Random.Range(0, gradeList.Count);
        return gradeList[index];
    }
}