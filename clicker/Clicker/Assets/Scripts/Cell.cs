using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cell : MonoBehaviour
{
    [SerializeField] private Text _description;
    [SerializeField] private Text _price;
    [SerializeField] private Button _button;

    public Text Description { get => _description; set => _description = value; }
    public Text Price { get => _price; set => _price = value; }
    public Button Button { get => _button; set => _button = value; }
}
