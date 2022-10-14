using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFall : MonoBehaviour
{
    [SerializeField] float fallSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetpos = transform.position;
        targetpos.y = fallSpeed;
        transform.Translate(targetpos * Time.deltaTime);
    }
}
