using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopGenerate : MonoBehaviour
{
    [SerializeField] private Cell _cell;
    [SerializeField] private Transform _transform;
    [SerializeField] private int _cellCount;

    void Start()
    {
        for(int i = 0; i < _cellCount; i++)
        {
            Cell cell = Instantiate(_cell, _transform);
            _cell.transform.position = new Vector2(cell.transform.position.x, cell.transform.position.y - 10);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
