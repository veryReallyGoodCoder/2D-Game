using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventsScript : MonoBehaviour
{
    public TMP_Text textBox;

    public GameObject canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextClick()
    {
        string newText = "Get Ready for a World of HURT!";

        textBox.text = newText;
        Debug.Log("New Text");
    }

}
