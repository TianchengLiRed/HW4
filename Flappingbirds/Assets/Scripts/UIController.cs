using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button restartButton;
    public GameObject gameoverPanel;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.interactable =false;
        restartButton.gameObject.SetActive(false);
        gameoverPanel.SetActive(false);

        restartButton.onClick.AddListener(()=> Restart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void End()
    {
        restartButton.interactable = true;
        restartButton.gameObject.SetActive(true);
        gameoverPanel.SetActive(true);
    }
    void Restart()
    {
        Debug.Log("restart");
        restartButton.gameObject.SetActive(false);
        gameoverPanel.SetActive(false);
    }
}
