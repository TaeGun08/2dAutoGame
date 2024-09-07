using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGoundChanger : MonoBehaviour
{
    public static BackGoundChanger Instance;

    [Header("���ȭ��")]
    [SerializeField] private List<Sprite> backGrounds;

    private Image backGoundImage; //�� ��ũ��Ʈ�� �ִ� Image�� �޾ƿ��� ���� ����

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
    /// �������� ���ȭ���� �ٲٱ� ���� ȣ���ϴ� �Լ�
    /// </summary>
    private void randomBackGound()
    {
        backGoundImage.sprite = backGrounds[Random.Range(0, backGrounds.Count)];
    }
}
