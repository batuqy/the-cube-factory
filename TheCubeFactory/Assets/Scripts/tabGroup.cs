using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
public class tabGroup : MonoBehaviour
{
    public List<tabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public tabButton selectedTab;
    public List<GameObject> objectsToSwap;
    public void Subscribe(tabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<tabButton>();
        }
        tabButtons.Add(button);
    }
     void Start()
    {
        ResetTabs();
    }
    public void OnTabEnter(tabButton button)
    {
        ResetTabs();
        if (selectedTab==null||button!=selectedTab)
        {
            button.background.sprite = tabHover;
        }
        
    }
    public void OnTabExit(tabButton button)
    {
        ResetTabs();
    }
    public void OnTabSelected(tabButton button)
    {
        if (selectedTab!=null)
        {
            selectedTab.Deselect();
        }
        selectedTab = button;

        selectedTab.Select();
        ResetTabs();
        button.background.sprite = tabActive;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i==index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }
    public void ResetTabs()
    {
        foreach (tabButton button in tabButtons)
        {
            if (selectedTab!=null && button==selectedTab)
            {
                continue;
            }
            button.background.sprite = tabIdle;
        }
    }
}

