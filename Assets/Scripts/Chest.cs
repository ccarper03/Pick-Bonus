using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    [SerializeField]
    private Image chestImage;
    public Sprite closed;
    public Sprite openEmpty;
    public Sprite openSm;
    public Sprite openMd;
    public Sprite openLg;
    public Sprite openXtaLg;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            chestImage.sprite = closed;
            Debug.Log("Closed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            chestImage.sprite = openEmpty;
            Debug.Log("Open empty");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            chestImage.sprite = openSm;
            Debug.Log("open small");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            chestImage.sprite = openMd;
            Debug.Log("open medium");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            chestImage.sprite = openLg;
            Debug.Log("open large");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            chestImage.sprite = openXtaLg;
            Debug.Log("open extra");
        }
    }
    public void ResetChest()
    {
        this.GetComponent<Button>().interactable = false;
        chestImage.sprite = closed;
    }
}
