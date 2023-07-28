using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class CutsceneController : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    public UnityEvent OnAnimationEnd, OnAnimationStart;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        OnAnimationStart.Invoke();
    }

    public void AnimationEnd()
    {
        OnAnimationEnd.Invoke();
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(2);
        Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<CameraController>().enabled = true;
    }

}