using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleOrInvisibleOnClick : MonoBehaviour {

    private Transform originalPosition;

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
            Vector3 currentPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
            Quaternion currentRotation = new Quaternion (transform.rotation.x, transform.rotation.y, transform.rotation.z, 0);
            } else
            {
                prefab.SetActive(true);
            }
    }
}
