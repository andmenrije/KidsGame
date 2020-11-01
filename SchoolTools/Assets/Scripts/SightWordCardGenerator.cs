using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

/// <summary>
/// This creates the sight word cards based on the stored list words
/// </summary>
public class SightWordCardGenerator : MonoBehaviour
{

    [SerializeField]
    private List<string> sightWords = new List<string>(10);
    [SerializeField]
    GameObject panelPrefab;

    private string currentWord;
    Timer sightWordTimer;

    // Start is called before the first frame update
    void Start()
    {
        //sightWordTimer = GetComponent<Timer>();
        //if (sightWordTimer != null)
        //{
        //    sightWordTimer.Duration = 2.0f;
        //    sightWordTimer.Run();
        //}



        panelPrefab.GetComponent<PanelDispay>().UpdateSightWord(currentWord);
    }


    private void Awake()
    {
        currentWord = "";
        
    }


    // Update is called once per frame
    void Update()
    {
        //if(sightWordTimer != null && !sightWordTimer.Running )
        //{
        //    Debug.Log("SightWord is " + RandomWordFromList());
        //    sightWordTimer.Run();
        //}
    }


    public void GenerateNextWordToDisplay()
    {
        int nextIndex = sightWords.IndexOf(currentWord);
        Debug.Log("SightWord index = " + nextIndex);
        nextIndex = (nextIndex + 1) % 10;
        Debug.Log("Next index = " + nextIndex);
        currentWord = sightWords[nextIndex];
        panelPrefab.GetComponent<PanelDispay>().UpdateSightWord(currentWord);
    }

    public void GenerateRandomWordToDisplay()
    {
        RandomWordFromList();
        panelPrefab.GetComponent<PanelDispay>().UpdateSightWord(currentWord);
    }


    private string RandomWordFromList()
    {

        int randomIndex = UnityEngine.Random.Range(0, sightWords.Count);
        while (currentWord == sightWords[randomIndex])
        {
            randomIndex = UnityEngine.Random.Range(0, sightWords.Count);
        }
        currentWord = sightWords[randomIndex];
        return currentWord;
    }

}
