using UnityEngine;

public class elevatortech : MonoBehaviour
{
    //bool playeron=false;
    private Animator animator;
    void Start()
    {
        animator= GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("playeron",true);
        }
        Debug.Log("elevator entered");
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("playeron",false);
        }
        Debug.Log("elevator exited");
    }
}
