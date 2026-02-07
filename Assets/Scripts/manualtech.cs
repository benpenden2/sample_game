using UnityEngine;

public class manualtech : MonoBehaviour, Interactable
{
    bool opened=false;

    public void interact()
    {   
        if(!opened){

            talktexttech.instance.textval="this is the manual";
            talktexttech.instance.textupdate();
            opened=true;

        }
        else
        {
            talktexttech.instance.cleartext();
            opened=false;
        }
    }
}
