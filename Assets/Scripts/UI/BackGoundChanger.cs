using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGoundChanger : MonoBehaviour
{
    public static BackGoundChanger Instance;

    [Header("배경화면")]
    [SerializeField] private List<Sprite> backGrounds;

    private Image backGoundImage; //이 스크립트에 있는 Image를 받아오기 위한 변수

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        backGoundImage = GetComponent<Image>();

        randomBackGound();
    }

    /// <summary>
    /// 랜덤으로 배경화면을 바꾸기 위해 호출하는 함수
    /// </summary>
    private void randomBackGound()
    {
        backGoundImage.sprite = backGrounds[Random.Range(0, backGrounds.Count)];
    }
}
