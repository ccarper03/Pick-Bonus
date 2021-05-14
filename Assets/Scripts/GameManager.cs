using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    private float lastGameWin;
    [SerializeField]
    private Text LastGameWinLbl;
    [SerializeField]
    private float balance;
    [SerializeField]
    private Text banlanceLbl;
    [SerializeField]
    private float[] denoAmt = {.25f,.50f,1.00f, 5.00 };
    [SerializeField]
    private Text denoLbl;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {

    }
    void DenominatorIncrease()
    {

    }
    void DenominatorDecrease()
    {

    }
}
