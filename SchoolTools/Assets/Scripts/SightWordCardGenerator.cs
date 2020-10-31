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
    List<GameObject> panelPrefab;

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

    }

    private void Awake()
    {

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


    
    private string RandomWordFromList()
    {

        int randomIndex = UnityEngine.Random.Range(0, sightWords.Count);
        return sightWords[randomIndex];
    }

}
