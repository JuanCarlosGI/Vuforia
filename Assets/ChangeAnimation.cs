using UnityEngine;

public class ChangeAnimation : MonoBehaviour {

    public Animator anim;

    public void Change(string str)
    {
        anim.SetBool(str, true);
    }
}
