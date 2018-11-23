using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleOrInvisibleOnClick : MonoBehaviour {

    public GameObject prefab;
    public Button m_button;

    void Start()
    {
        m_button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

            if (prefab.activeInHierarchy)
            {
                prefab.SetActive(false);
            } else
            {
                prefab.SetActive(true);
            }
        
    }
}
