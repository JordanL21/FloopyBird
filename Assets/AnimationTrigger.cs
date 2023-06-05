using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    private Animator wingsAnimator;

    // Start is called before the first frame update
    void Start()
    {
        wingsAnimator = transform.Find("Wing Flap").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wingsAnimator.SetTrigger("Flap");
        }
    }
}
