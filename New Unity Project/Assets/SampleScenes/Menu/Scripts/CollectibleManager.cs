using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalBurgs;
    private int _collectedBurgs;

    public TextMeshProUGUI burgCount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _totalBurgs = FindObjectsOfType<Collectible>().Length;
    }

    void DisplayBurgCount()
    {
        burgCount.SetText(_collectedBurgs + " / " + _totalBurgs);


    }

   public void HandleBurgCollected()
    {
        _collectedBurgs++;
        DisplayBurgCount();
        if(_collectedBurgs == _totalBurgs)
        {
            WinMenu.Instance.Show();
            SoundManager.Instance.PlayWinSound();
        }

        else SoundManager.Instance.PlayCoinCollectSound();
    }
}
