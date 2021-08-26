using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListView : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform m_ContentTransform;
    [SerializeField] private RectTransform m_ContentRectTrransform;

    [Header("Settings")]
    [SerializeField] private List<GameObject> m_elements;
    [SerializeField] private float m_offset;

    public GameObject Add(GameObject element)
    {
        GameObject createdElement = Instantiate(element, this.m_ContentTransform);
        if(this.m_elements.Count == 0)
        {
            this.m_elements.Add(createdElement);
            return createdElement;
        }

        ListElement elementMeta = createdElement.GetComponent<ListElement>();

        GameObject lastElement = this.m_elements.Last();

        Vector3 lastElementPossition = lastElement.transform.localPosition;

        Vector3 newElementPossition = new Vector3
        {
            x = lastElementPossition.x,
            y = lastElementPossition.y - elementMeta.Height() - this.m_offset,
            z = lastElementPossition.z,
        };

        createdElement.transform.localPosition = newElementPossition;

        this.m_elements.Add(createdElement);

        float contentHeight = this.m_ContentRectTrransform.rect.height;

        contentHeight += this.m_offset + elementMeta.Height();

        this.m_ContentRectTrransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);

        return createdElement;
    }
}
