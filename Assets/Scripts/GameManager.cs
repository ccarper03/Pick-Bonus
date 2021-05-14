using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class GameManager : Singleton<GameManager>
{
    
    [SerializeField]
    private Text LastGameWinLbl;
    [SerializeField]
    private Text banlanceLbl;
    [SerializeField]
    private Text denoLbl;

    private float lastGameWin;
    private float balance = 10.00f;
    private int denoIndex = 0;
    private float[] denoAmt = { .25f, .50f, 1.00f, 5.00f };
    // Start is called before the first frame update
    void Start()
    {
        denoIndex = 0;
        denoLbl.text = "$" + denoAmt[denoIndex].ToString();
        banlanceLbl.text = "$" + balance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        // get the Denomination
        // setup the switch 
        // lose 50%
        //   0-50
        // 30%
        //   1x-10x
        // 15%
        //   12x 16x 24x 32x 48x 64x
        // 5%
        //   100x 200x 300x 400x 500x
    }
    void DenominatorIncrease()
    {

    }
    void DenominatorDecrease()
    {

    }



    
}
