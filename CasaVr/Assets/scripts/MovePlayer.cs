using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 10;
    bool isFoward = false;
    bool isBack = false;
    bool isLeft = false;
    bool isRight = false;

    void Update()
    {
        if (isFoward)
        {
            transform.Translate(0, 0, (speed *Time.deltaTime));
        }
        if (isBack)
        {
            transform.Translate(0, 0, (-speed * Time.deltaTime));
        }
        if (isLeft)
        {
            transform.Translate((-speed * Time.deltaTime), 0, 0);
        }
        if (isRight)
        {
            transform.Translate((speed * Time.deltaTime), 0, 0);
        }
    }
    void EnableMoveController(bool frente = false,bool tras = false, bool esquerda = false, bool direita = false)
    {
        if(frente)
            isFoward = frente;
        if (tras)
            isBack = tras;
        if (esquerda)
            isLeft = esquerda;
        if (direita)
            isRight = direita;
    }
    public void DisableMoveController()
    {
        isFoward = false;
        isBack = false;
        isLeft = false;
        isRight = false;
    }

    public void Foward()
    {
        EnableMoveController(true);
    }
    public void Back()
    {
        EnableMoveController(false,true);
    }
    public void Left()
    {
        EnableMoveController(false,false,true);
    }
    public void Right()
    {
        EnableMoveController(false,false,false,true);
    }
}
