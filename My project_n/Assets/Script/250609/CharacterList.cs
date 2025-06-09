using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    List<string> topGrade = new List<string>();
    List<string> secondGrade = new List<string>();
    List<string> normalGrade = new List<string>();

    int totalDrawCount = 0; // 전체 누적 뽑기 횟수

    // Start is called before the first frame update
    void Start()
    {
        topGrade.Add("엘리시아");
        topGrade.Add("케빈");

        secondGrade.Add("아포니아");
        secondGrade.Add("에덴");
        secondGrade.Add("빌브이");
        secondGrade.Add("칼파스");

        normalGrade.Add("수");
        normalGrade.Add("사쿠라");
        normalGrade.Add("코스마");
        normalGrade.Add("뫼비우스");
        normalGrade.Add("그리세오");
        normalGrade.Add("화");
        normalGrade.Add("피르도 필리스");

        // Start()에서는 이제 자동으로 돌리지 않음!
        // 버튼 클릭 시 TenDraw()가 실행되도록 만듦
    }

    // public 으로 바꿔야 Button에서 호출 가능
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

        // 80연차 천장 발동
        if (totalDrawCount >= 80)
        {
            Debug.Log("80연차 천장 발동! 최고 등급 확정 지급");
            string topCharacter = GetRandomCharacter(topGrade);
            drawResults[0] = topCharacter; // 첫번째 뽑기 자리에 최고 등급 강제 삽입
            totalDrawCount = 0; // 천장 초기화
        }

        // 결과 출력
        Debug.Log("===== 10연차 결과 =====");
        for (int i = 0; i < drawResults.Count; i++)
        {
            Debug.Log($"뽑기 {i + 1}: {drawResults[i]}");
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