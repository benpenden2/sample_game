using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{   
    public static scoremanager instance;
    public TextMeshProUGUI moneycounter;
    private int money = 0;
    void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        UpdateMoneyDisplay();
    }
    
    public void AddMoney()
    {
        money +=5;
        UpdateMoneyDisplay();
    }
    void UpdateMoneyDisplay()
    {
        moneycounter.text = "$: " + money;
    }
}
