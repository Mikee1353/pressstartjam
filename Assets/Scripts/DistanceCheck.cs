using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public GameObject checkBox;
    private float _distanceBetween;
    private float _trueDistance = 0.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _distanceBetween = Vector2.Distance(transform.position, checkBox.transform.position);
        //Debug.Log(_distanceBetween);
        ButtonandDistanceCheck();


    }


    public void ButtonandDistanceCheck()
    {

        //B BUTTON
        if (CompareTag("BButton"))
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("You press B");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("You are a loser!");
                }
            }
        }


        //Y BUTTON
        if (CompareTag("YButton"))
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Debug.Log("You press Y");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("You are a loser!");
                }
            }
        }


        //U BUTTON
        if (CompareTag("UButton"))
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Debug.Log("You press U");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("You are a loser!");
                }
            }
        }


        //I BUTTON
        if (CompareTag("IButton"))
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("You press I");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("You are a loser!");
                }
            }
        }


        //O BUTTON
        if (CompareTag("OButton"))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("You press O");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("You are a loser!");
                }
            }
        }


    }
}
