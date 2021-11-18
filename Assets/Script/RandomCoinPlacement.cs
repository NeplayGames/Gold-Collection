
using System.Collections.Generic;
using UnityEngine;

public class RandomCoinPlacement : MonoBehaviour
{
    [SerializeField] List<Transform> coins = new List<Transform>();
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] float distanceBetweenCoins;
    void Start()
    {
        PlaceCoinOnPlane();
    }

    ///<Summary>
    ///Randomly place the coin on the plane according to the start and end point 
    ///</sumammary>
    private void PlaceCoinOnPlane()
    {
       int row = (int)(Mathf.Abs(startPoint.position.x - endPoint.position.x)/distanceBetweenCoins);
       int column = (int)(Mathf.Abs(startPoint.position.z - endPoint.position.z)/distanceBetweenCoins);

        for (int i = 0; i <=row; i++)
        {
            for(int j =0; j <=column; j++)
            {
                Instantiate(coins[Random.Range(0, coins.Count)], startPoint.position + Vector3.forward * i * distanceBetweenCoins + Vector3.right * j * distanceBetweenCoins, Quaternion.Euler(new Vector3(90, 0, 0)));
            }
        }
    }

}
