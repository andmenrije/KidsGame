using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonActionManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> SightWordListContainer;
    [SerializeField]
    private UnityEngine.UI.Button randomButton;
    [SerializeField]
    private UnityEngine.UI.Button nextWordButton;
    [SerializeField]
    private UnityEngine.UI.Button goToPreviousList;
    [SerializeField]
    private UnityEngine.UI.Button goToNextList;
    [SerializeField]
    private UnityEngine.UI.Button quitApplication;
    [SerializeField]
    TMP_Text SightWordLabel;

    int currentGameObjectIndex;

    // Called when this game object is instantiated
    private void Awake()
    {
        currentGameObjectIndex = 0;
    }
    // Start is called before the first frame update
    void Start()
    {


        UnityEngine.UI.Button randBtn = randomButton.GetComponent<UnityEngine.UI.Button>();
        randBtn.onClick.AddListener(GenerateRandomWordToDisplay);

        UnityEngine.UI.Button nextBtn = nextWordButton.GetComponent<UnityEngine.UI.Button>();
        nextBtn.onClick.AddListener(GenerateNextWordToDisplay);

        UnityEngine.UI.Button prevListBtn = goToPreviousList.GetComponent<UnityEngine.UI.Button>();
        prevListBtn.onClick.AddListener(GoToPreviousList);

        UnityEngine.UI.Button nextListBtn = goToNextList.GetComponent<UnityEngine.UI.Button>();
        nextListBtn.onClick.AddListener(GoToNextList);

        UnityEngine.UI.Button quitBtn = quitApplication.GetComponent<UnityEngine.UI.Button>();
        quitBtn.onClick.AddListener(OnQuitButton);

        SightWordListContainer[currentGameObjectIndex].SetActive(true);
        UpdateLabel();
    }

    private void GoToNextList()
    {
        Debug.Log("Move to next List");
        SightWordListContainer[currentGameObjectIndex].SetActive(false);
        currentGameObjectIndex = (currentGameObjectIndex + 1) % SightWordListContainer.Count;
        SightWordListContainer[currentGameObjectIndex].SetActive(true);
        UpdateLabel();
    }

    private void GoToPreviousList()
    {

        Debug.Log("Move to previous List");
        SightWordListContainer[currentGameObjectIndex].SetActive(false);
        currentGameObjectIndex = (currentGameObjectIndex - 1) < 0? SightWordListContainer.Count - 1 : currentGameObjectIndex - 1;
        SightWordListContainer[currentGameObjectIndex].SetActive(true);
        UpdateLabel();
    }

    private void GenerateNextWordToDisplay()
    {

        Debug.Log("Generate next word to display");
        SightWordListContainer[currentGameObjectIndex].GetComponent<SightWordCardGenerator>().GenerateNextWordToDisplay();
    }

    private void GenerateRandomWordToDisplay()
    {

        Debug.Log("Generate random word to display");
        SightWordListContainer[currentGameObjectIndex].GetComponent<SightWordCardGenerator>().GenerateRandomWordToDisplay();
    }

    private void OnQuitButton()
    {
        Camera.main.GetComponent<GameManager>().QuitApplication();
    }

    private void UpdateLabel()
    {
        SightWordLabel.text = "List " + (currentGameObjectIndex + 1);
    }


}
