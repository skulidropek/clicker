using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ExampleComponent : MonoBehaviour
{
    [System.Serializable]
    public enum Shop 
    {
        AutoClick = 0,
        AddClick = 1,
    }
    class ClickBuy
    {

    }
    public struct Cell
    {
        public Sprite sprite;
        public string title;
        public string description;
        public int click;
        //public ButtonMeta button;
    }
    [Header("Components")]
    [SerializeField] private ListView m_ListView;
    [SerializeField] private GameObject m_Prefab;

    [Header("Settings")]
    [SerializeField] private List<Cell> m_Cells;

    private void Awake()
    {
        //for (int i = 0; i < this.m_Count; i++)
        //{
            GameObject element = this.m_ListView.Add(this.m_Prefab);

            ListElement elementMeta = element.GetComponent<ListElement>();
            foreach(Cell cell in m_Cells)
            {
                elementMeta.SetTitle(cell.title);
                elementMeta.SetDescription(cell.description);

                //ButtonMeta buttonMeta = GetRandomButtonMeta();

                elementMeta.SetImage(cell.sprite);
               // elementMeta.SetButtonColor(cell.buttonColor);

                Button actionButton = elementMeta.GetActionButton();
                actionButton.onClick.AddListener(() =>
                {
                    Debug.Log("Сообщение");
                    BuyClick(cell.click);
                });
            }

            //elementMeta.SetImage(GetRandomSprite());
        //}
    }

    public void BuyClick(int value)
    {
        FindObjectOfType<GameManager>().ClickValue += value;
        Debug.Log($"Вы купили кликов {value}. Теперь 1 ваш клик равен {value}");
    }

}
