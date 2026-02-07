using UnityEngine;
using TMPro;

public class moneytech : MonoBehaviour, Interactable
{

    public void interact()
    {
        scoremanager.instance.AddMoney();
        Destroy(gameObject);
    }
}
