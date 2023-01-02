using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitButton : MonoBehaviour
{
    public bool isHit;
    public Counter counter;
    public Player Rota;
    internal int TurnValue = 0;
    internal float playerRot;
    public void OnButtonClick()
    {
        // �ok uzun oldu�undan k�saltt�m
        playerRot = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
        //Y�zlerle tek tek u�ra�mamak i�in for d�ng�s�ne ald�m
        for (int i = 0; i <= 3; i++)
        {
            if (playerRot >= 85 * i && playerRot <= 95 * i && !isHit)
            {
                Rota.transform.rotation = Rota.zeroPoint;// K�p her do�ru clickte 0 lan�yor
                StartCoroutine(ResetHit());
                counter.IncreaseCounter();
                TurnValue += 1;// E�er click do�ru at�l�rsa k�p z ekseni etraf�nda d�nmeye ba
                isHit = true;
            }
        }
    }
    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }
}