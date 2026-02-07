using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class talktexttech : MonoBehaviour
{
    public static talktexttech instance;
    public string textval="";
    public TextMeshProUGUI talktext;
    public GameObject texttalkbg;

    void Start()
    {
        talktext.text= textval;
    }
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && texttalkbg.activeInHierarchy)
        {
            cleartext();
        }
    }
    void Awake()
    {
        if (instance == null) instance = this;
    }
    public void textupdate()
    {   
        texttalkbg.SetActive(true);
        talktext.text=textval;
    }
    public void cleartext()
    {
        textval = "";
        textupdate();
        texttalkbg.SetActive(false);
    }
}
