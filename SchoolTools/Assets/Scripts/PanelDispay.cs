using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelDispay : MonoBehaviour
{
    [SerializeField]
    private TMP_Text sightWord;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSightWord(string sightWord)
    {
        this.sightWord.text = sightWord;
    }
}
