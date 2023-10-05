using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public delegate void CoinCollectedEventHandler();
    public static event CoinCollectedEventHandler OnCoinCollected;

    // Update is called once per frame
    void Update()
    {
        // You can add any rotation or animation logic here if you wish.
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we collided with has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Trigger the OnCoinCollected event before destroying the coin
            OnCoinCollected?.Invoke();

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
