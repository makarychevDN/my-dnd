using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PageSelector : MonoBehaviour
{
    private List<Page> _allPages;

    public void Select(Page page)
    {
        _allPages.ForEach(anyPage => anyPage.gameObject.SetActive(false));
        page.gameObject.SetActive(true);
    }

    private void Awake()
    {
        _allPages = FindObjectsOfType<Page>().ToList();
    }
}
