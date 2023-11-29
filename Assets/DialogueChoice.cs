using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using UnityEngine.UI;
using Articy.Unity.Interfaces;

public class DialogueChoice : MonoBehaviour
{
    private Branch branch;
        private ArticyFlowPlayer flowPlayer;

    [SerializeField]
    private Text buttonText;

    public void AssignBranch(ArticyFlowPlayer player, Branch branch)
    {
        this.flowPlayer = player;
        this.branch = branch;

        IFlowObject target = branch.Target;

        buttonText.text = string.Empty;

        var objectWithMenuText = target as IObjectWithMenuText;

        if(objectWithMenuText != null)
        {
            buttonText.text = objectWithMenuText.MenuText;
        }
        

    }

    public void AssignCont(ArticyFlowPlayer player, Branch branch)
    {
        this.flowPlayer = player;
        this.branch = branch;

        buttonText.text = "Continue";
    }

    public void BranchSelected()
    {
        flowPlayer.Play(branch);
    }
}
