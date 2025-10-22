using UnityEngine;

public class SwordScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("IsSwinging", true);
        }
        else
        {
            animator.SetBool("IsSwinging", false);
        }
    }
}