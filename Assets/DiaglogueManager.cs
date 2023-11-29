using Articy.Articy_Draft_Test_Drive;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaglogueManager : MonoBehaviour
{
    [SerializeField]
    private GameObject dialogueWidget;

    [SerializeField]
    private Transform branchPanel;

    [SerializeField]
    private Text dialogueText;

    [SerializeField]
    private GameObject dialogueChoiceButton;

    [SerializeField]
    private GameObject closeButton;

    private ArticyFlowPlayer flowPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
        flowPlayer = GetComponent<ArticyFlowPlayer>();
        dialogueWidget.SetActive(false);

    }

    public void StartDialogue(IArticyObject articyObj)
    {
        dialogueWidget.SetActive(true);
        flowPlayer.StartOn = articyObj;

    }

    public void StopDialogue()
    {
        dialogueWidget.SetActive(false);
        flowPlayer.FinishCurrentPausedObject();

        foreach(Transform child in branchPanel)
        {
            Destroy(child.gameObject);
        }

        flowPlayer.StartOn = null;
    }

    public void OnFlowPlayerPaused(IFlowObject flowObj)
    {
        dialogueText.text = string.Empty;

        string speaker = string.Empty;
        var objWithSpeakerText = flowObj as IObjectWithSpeaker;

        if(objWithSpeakerText != null)
        {
            var speakerEntity = objWithSpeakerText.Speaker as Entity;

            speaker = speakerEntity.DisplayName;
        }

        var objWithText = flowObj as IObjectWithText;

        if (objWithText != null)
        {
            var textEntity = objWithText.Text;

            dialogueText.text = $"{speaker}\n{textEntity}";
        }

    }

    public void OnBranchesUpdated(IList<Branch> branches)
    {
        foreach (Transform child in branchPanel)
        {
            Destroy(child.gameObject);
        }

        bool dialogueIsDone = true;

        foreach(var branch in branches)
        {
            if(branch.Target is DialogueFragment)
            {
                dialogueIsDone = false;
            }
        }

        if(dialogueIsDone == false)
        {
            if(branches.Count == 1)
            {
                GameObject button = Instantiate(dialogueChoiceButton, branchPanel.transform);
                button.GetComponent<DialogueChoice>().AssignCont(flowPlayer, branches[0]);
            }
            else
            {
                foreach(Branch branch in branches)
                {
                    GameObject button = Instantiate(dialogueChoiceButton, branchPanel.transform);
                    button.GetComponent<DialogueChoice>().AssignBranch(flowPlayer, branch);
                }
            }
        }
        else
        {
            GameObject button = Instantiate(closeButton, branchPanel.transform);
            var buttonComponent = button.GetComponent<Button>();
            buttonComponent.onClick.AddListener(StopDialogue);
        }
    }

}
