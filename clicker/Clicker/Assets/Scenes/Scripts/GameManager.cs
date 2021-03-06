using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _clickCount;
    [SerializeField] private Text _clickText;
    
    void Start()
    {
        StartCoroutine(AutoClick(1, 1));
    }

    void Update()
    {
        _clickText.text = _clickCount.ToString();
    }

    public void Click(int value)
    {
        _clickCount += value;
    }

    public IEnumerator AutoClick(int value, float timer)
    {
        while(true)
        {
            Click(value);
            yield return new WaitForSeconds(timer);
        }
    }
}
