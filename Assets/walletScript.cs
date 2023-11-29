using Articy.Articy_Draft_Test_Drive.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walletScript : MonoBehaviour
{
    [SerializeField]
    private Text walletText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walletText.text = $"R{ArticyGlobalVariables.Default.playerVars.Wallet}";
    }
}
