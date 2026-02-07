using UnityEngine;

public class doortech : MonoBehaviour, Interactable
{
    
    bool openbool=false;
    private Animator animator;
    Outline outline;
    void Start()
    {
        animator= GetComponent<Animator>();
    }
    public void interact()
    {
        openbool= !openbool;
        animator.SetBool("opened",openbool);
    }
}