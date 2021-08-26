using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Serializable] public enum Click
    {
        Auto = 0,
        Standart = 1,
    }
    [Serializable] public struct Cell
    {
        public Sprite sprite;
        public string title;
        public string description;
        public Click shop;
        public int clickCount;
    }

    [Header("Components")]
    [SerializeField] private ListView m_ListView;
    [SerializeField] private GameObject m_Prefab;

    [Header("Settings")]
    [SerializeField] private List<Cell> m_Cells;

    private void Awake()
    {
        foreach (Cell cell in m_Cells)
        {
            GameObject element = this.m_ListView.Add(this.m_Prefab);

            ListElement elementMeta = element.GetComponent<ListElement>();
            elementMeta.SetTitle(cell.title);
            elementMeta.SetDescription(cell.description);
            elementMeta.SetImage(cell.sprite);

            Button actionButton = elementMeta.GetActionButton();
            actionButton.onClick.AddListener(() =>
            {
                if (cell.shop == Click.Standart)
                    BuyClick(cell.clickCount);
                else if (cell.shop == Click.Auto)
                    BuyAutoClick(cell.clickCount);

            });
        }
    }

    public void BuyClick(int value)
    {
        FindObjectOfType<GameManager>().ClickValue += value;
        Debug.Log($"Вы купили кликов {value}. Теперь 1 ваш клик равен {value}");
    }
    public void BuyAutoClick(int value)
    {
        FindObjectOfType<GameManager>().AutoClickValue += value;
        Debug.Log($"Вы купили кликов {value}. Теперь 1 ваш клик равен {value}");
    }

}
