using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.UIElements;

public class GameManager : Singleton<GameManager>
{
    
    [SerializeField]
    private Text LastGameWinLbl;
    [SerializeField]
    private Text banlanceLbl;
    [SerializeField]
    private Text denoLbl;

    private float lastGameWin;
    [SerializeField]
    private float currentBalance = 10.00f;
    private int denoIndex = 0;
    private float[] denoAmt = { .25f, .50f, 1.00f, 5.00f };
    private float denominator;
    private float winningTotal;
    private int multiplier;    
    private int[] winMultiplyerOnes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private int[] winMultiplyerTens = { 12, 16, 24, 32, 48, 64 };
    private int[] winMultiplyerHundreds = { 100, 200, 300, 400, 500 };
    private AudioSource audioSource;
    public AudioSource AudioSource
    {
        get { return audioSource; }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        denoIndex = 0;
        denoLbl.text = denoAmt[denoIndex].ToString("C");
        banlanceLbl.text = currentBalance.ToString("C");
    }

    public void Play()
    {
        if (denoAmt[denoIndex] <= currentBalance) // Check if you have enough in balance for Denomination amount
        {
            float randNum = Random.value;
            if (randNum <= .5f)// 50%
            {
                Debug.Log(randNum + " 50%");
                // Get input 
                denominator = denoAmt[denoIndex];

                // Calculate the values

                // Output the results
                LastGameWinLbl.text = "$0.00";
                banlanceLbl.text = (currentBalance -= denominator).ToString("C");
            }
            else if (randNum > .5f && randNum < .8f) // 30%
            {
                Debug.Log(randNum + " 30%");
                // Get input 
                multiplier = winMultiplyerOnes[Random.Range(0,10)];
                denominator = denoAmt[denoIndex];

                // Calculate the values
                banlanceLbl.text = (currentBalance -= denominator).ToString("C");
                winningTotal = multiplier * denominator;
                currentBalance += winningTotal;

                // Output the results
                banlanceLbl.text = currentBalance.ToString("C");
                LastGameWinLbl.text = winningTotal.ToString("C");

            }
            else if (randNum > .80f && randNum < .95f) // 15%
            {
                Debug.Log(randNum + " 15%");
                // Get input 
                multiplier = winMultiplyerTens[Random.Range(0, 6)];
                denominator = denoAmt[denoIndex];

                // Calculate the values
                banlanceLbl.text = (currentBalance -= denominator).ToString("C");
                winningTotal = multiplier * denominator;
                currentBalance += winningTotal;

                // Output the results
                banlanceLbl.text = currentBalance.ToString("C");
                LastGameWinLbl.text = winningTotal.ToString("C");
            }
            else if (randNum > .95f) // 5%
            {
                Debug.Log(randNum + " 5%");
                // Get input 
                multiplier = winMultiplyerHundreds[Random.Range(0, 5)];
                denominator = denoAmt[denoIndex];

                // Process Calculations
                banlanceLbl.text = (currentBalance -= denominator).ToString("C");
                winningTotal = multiplier * denominator;
                currentBalance += winningTotal;

                // Output the results
                banlanceLbl.text = currentBalance.ToString("C");
                LastGameWinLbl.text = winningTotal.ToString("C");
            }
        }
        else
        {
            
        }
    }

    // Add Denomination Button
    public void DenominatorIncrease()
    {
        if (denoIndex <= 2)
        {
            denoIndex++;
            denoLbl.text = denoAmt[denoIndex].ToString("C");
            GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.IncreaseClick);
        }
    }

    // Subtract Denomination Button
    public void DenominatorDecrease()
    {
        if (denoIndex > 0)
        {
            denoIndex--;
            denoLbl.text = denoAmt[denoIndex].ToString("C");
            GameManager.Instance.AudioSource.PlayOneShot(SoundManager.Instance.DecreaseClick);
        }
    }
}
