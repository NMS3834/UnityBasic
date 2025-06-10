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
                star += "★";
            }
            star += "\n"; ; // 줄 바꿈 반드시 추가해야 Console 에서 잘 나옴
        }

        Debug.Log(star);
    }


    public void Phase2()
    {
        star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            // 공백 출력
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // 별 출력
            for (int k = 1; k <= i; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 1단계: 별 개수 1 ~ 5 증가
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        // 2단계: 별 개수 4 ~ 1 감소
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

        // 1단계: 증가하는 삼각형
        for (int i = 1; i <= 5; i++)
        {
            // 공백 출력
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // 별 출력
            for (int k = 1; k <= i; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        // 2단계: 감소하는 삼각형
        for (int i = 4; i >= 1; i--)
        {
            // 공백 출력
            for (int j = 1; j <= 5 - i; j++)
            {
                star += " ";
            }

            // 별 출력
            for (int k = 1; k <= i; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        int n = 5; // 총 줄 수 (마름모 반쪽 기준 줄 수)

        // 1단계: 위쪽 삼각형 (1~n줄)
        for (int i = 1; i <= n; i++)
        {
            // 공백 출력
            for (int j = 1; j <= n - i; j++)
            {
                star += " ";
            }

            // 별 출력 (2*i - 1개 출력)
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        // 2단계: 아래쪽 삼각형 (n-1 ~ 1줄)
        for (int i = n - 1; i >= 1; i--)
        {
            // 공백 출력
            for (int j = 1; j <= n - i; j++)
            {
                star += " ";
            }

            // 별 출력 (2*i - 1개 출력)
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }
}
