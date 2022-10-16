using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxScript : MonoBehaviour
{
    public GameObject Space_button, T_button, Y_button, U_Button, I_button;
    GameManager gameManager;

    private Vector2 transformpos;
    private Vector2 offSet;
    RaycastHit2D hit;
    private float distance;

    public KeyCode keyCode;
    public GameObject targetSquare;

    private void Start()
    {
        offSet = new Vector2(0, 0.25f);

        transformpos = transform.position;
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        ButtonCheck();

    }

    void ButtonCheck()
    {
        if (Input.GetKeyDown(keyCode))
        {
            hit = Physics2D.Raycast(transformpos - offSet, Vector2.up, 0.5f);

            // hit to something
            Debug.DrawLine(transformpos - offSet, hit.point, Color.red);
            
            if (hit.collider == null)
            {
                gameManager.HealthDecrease();
            }
            else
            {
                Destroy(hit.collider.gameObject);
            }

            /*
            if (hit.collider.tag == targetSquare.tag)
            {
                Debug.Log(hit.collider.tag);
                // do?ru hit
                Destroy(hit.collider.gameObject);
            }
            else
            {
                // yanl?? hit
                
            } */
        }
        else
        {
            // not hit

            Debug.DrawLine(transformpos - offSet, Vector2.up * distance, Color.green);
        }


    }
}

        /*

        //Y BUTTON
        if (hit.collider == Y_button.CompareTag("YButton"))
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Debug.Log("You press Y");
                if (distance > 0)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    gameManager.HealthDecrease();
                }
            }
        }


        //U BUTTON
        if (hit.collider == U_Button.CompareTag("UButton"))
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Debug.Log("You press U");
                if (distance > 0)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    gameManager.HealthDecrease();
                }
            }
        }


        //I BUTTON
        if (hit.collider == I_button.CompareTag("IButton"))
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("You press I");
                if (distance > 0)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    gameManager.HealthDecrease();
                }
            }
        }


        //O BUTTON
        if (hit.collider == T_button.CompareTag("OButton"))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("You press O");
                if (distance > 0)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    gameManager.HealthDecrease();
                }
            }
        } */
    

