using System.Collections.Generic;
using UnityEngine;

public class BrowserManager : MonoBehaviour
{
    [System.Serializable]
    public class BrowserPage
    {
        public string pageName;
        public GameObject page;
    }

    [SerializeField]
    private List<BrowserPage> pages = new();

    public void OpenPage(string pageName)
    {
        foreach (var page in pages)
        {
            page.page.SetActive(page.pageName == pageName);
        }
    }
}