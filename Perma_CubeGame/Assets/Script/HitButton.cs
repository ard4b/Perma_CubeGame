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
        // Çok uzun olduðundan kýsalttým
        playerRot = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
        //Yüzlerle tek tek uðraþmamak için for döngüsüne aldým
        for (int i = 0; i <= 3; i++)
        {
            if (playerRot >= 85 * i && playerRot <= 95 * i && !isHit)
            {
                Rota.transform.rotation = Rota.zeroPoint;// Küp her doðru clickte 0 lanýyor
                StartCoroutine(ResetHit());
                counter.IncreaseCounter();
                TurnValue += 1;// Eðer click doðru atýlýrsa küp z ekseni etrafýnda dönmeye ba
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