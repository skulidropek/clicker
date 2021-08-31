using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _clickCount;
    [SerializeField] private Text _clickText;

    private bool _autoClickActive;
    private int _clickValue;
    private int _autoClickValue;
    public int ClickValue { get => _clickValue; set => _clickValue = value; }
    public int AutoClickValue { get => _autoClickValue; set => _autoClickValue = value; }

    void Start()
    {
        StartCoroutine(AutoClick(0, 1));
    }

    void Update()
    {
        _clickText.text = _clickCount.ToString();
        //if(_autoClickActive)
    }

    public void Click(int value, bool autoClick = false)
    {
        if (!autoClick)
            value += _clickValue;
        _clickCount += value;
    }
    public void Click(int value)
    {
        value += _clickValue;
        _clickCount += value;
    }

    public IEnumerator AutoClick(int value, float timer)
    {
        while (true)
        {
            // if (!_autoClickActive) break;

            Click(value + AutoClickValue);
            yield return new WaitForSeconds(timer);
        }
    }
}