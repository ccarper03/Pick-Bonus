using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestManager :Singleton<ChestManager>
{

    [SerializeField] private Sprite close;
    [SerializeField] private Sprite openEmpty;
    [SerializeField] private Sprite openSm;
    [SerializeField] private Sprite openMd;
    [SerializeField] private Sprite openLg;
    [SerializeField] private Sprite openXtaLg;
    [SerializeField] private GameObject[] Chests;

    public void DisableChest()
    {
        GetComponent<Button>().interactable = false;
    }
    public void DisableAllChests()
    {
        foreach (var chest in Chests)
        {
            chest.GetComponent<Button>().interactable = false;
        }
    }
    public void EnableAllChests()
    {
        foreach (var chest in Chests)
        {
            chest.GetComponent<Button>().interactable = true;
        }
    }
    public void CloseAllChests()
    {
        foreach (var chest in Chests)
        {
            chest.GetComponent<Image>().sprite = close;
        }
    }
    public void CloseChest()
    {
        GetComponent<Image>().sprite = close;
    }
    public void OpenSmChest( )
    {
        GetComponent<Image>().sprite = openSm;
    }
    public void OpenMdChest()
    {
        GetComponent<Image>().sprite = openMd;
    }
    public void OpenLgChest()
    {
        GetComponent<Image>().sprite = openLg;
    }
    public void OpenXtaLgChest()
    {
        GetComponent<Image>().sprite = openXtaLg;
    }
}
