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
        // Cok uzun oldugundan kisalttim
        playerRot = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
        //Yuzlerle tek tek ugrasmamak icin for dongusune aldim
        for (int i = 0; i <= 3; i++)
        {
            if (playerRot >= 85 * i && playerRot <= 95 * i && !isHit)
            {
                Rota.transform.rotation = Rota.zeroPoint;// Kup her dogru clickte 0 laniyor
                StartCoroutine(ResetHit());
                counter.IncreaseCounter();
                TurnValue += 1;// Counter cift sayi ise x tek sayi ise z ekseninde donmeye basliyor
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