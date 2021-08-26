using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCloseWindowClick()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
    
    public void Close() => gameObject.SetActive(false);

    public void Open() => gameObject.SetActive(true);
}
