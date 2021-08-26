using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListElement : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private RectTransform m_transform;
    [Space]
    [SerializeField] private Image m_image;
    [Space]
    [SerializeField] private Text m_title;
    [SerializeField] private Text m_description;
    [Space]
    [SerializeField] private Button m_ActionButton;
    [SerializeField] private Text m_ButtonText;
    //[SerializeField] private Color m_ButtonImage;

    public void SetTitle(string title) => m_title.text = title;
    public void SetDescription(string description) => m_description.text = description;
    public void SetImage(Sprite image) => m_image.sprite = image;

    public float Width() => m_transform.rect.width;
    public float Height() => m_transform.rect.height;

  //  public void SetButtonColor(Color color) => this.m_ActionButton.image.color = color;
    public void SetButtonTitle(string title) => this.m_ButtonText.text = title;
    public Button GetActionButton() => this.m_ActionButton;
}
