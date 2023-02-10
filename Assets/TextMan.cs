using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMan : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI difficultyText;
    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        Load();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
      difficultyText.text = PlayerPrefs.GetString("difficulty");
    }
   
}
