using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoins : MonoBehaviour
{
    [SerializeField] bool isValuable = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isValuable)
            {
                ScoreCounter.Instance.IncreaseScoreCount();
                SoundController.Instance.CoinCollect();
            }
            else
            {
                //Once the player touches any other coin beside the gold the game halts.
                ScoreCounter.Instance.ShowGameOver();
                SoundController.Instance.WrongCoinCollect();
            }
            Destroy(this.gameObject);
        }
    }
}
