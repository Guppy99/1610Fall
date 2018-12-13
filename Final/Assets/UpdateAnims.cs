using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAnims : MonoBehaviour
{
    private Animator anims;

    public float speed;

    void Start()
    {
        anims = GetComponent<Animator>();
    }

    void Update()
    {
        anims.SetFloat("Speed", speed);
    }
}
