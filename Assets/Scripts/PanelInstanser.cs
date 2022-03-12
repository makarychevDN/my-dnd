using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInstanser : MonoBehaviour
{
    [SerializeField] private Transform parentOfInstance;
    [SerializeField] private Transform panelOfAddButton;
    [SerializeField] private GameObject prefab;

    public void InstantiatePanel()
    {
        Instantiate(prefab, parentOfInstance);
        panelOfAddButton.SetAsLastSibling();
    }
}
