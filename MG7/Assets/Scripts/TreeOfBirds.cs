using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Bird[] listOfBirds;
    [SerializeField] private float interDistanceMin;
    [SerializeField] private Transform playerTransform;




    private void Update(){

        for (int i = 0; i < listOfBirds.Length; i++)
        {
            Bird birdie = listOfBirds[i];
            float interDistance = Vector3.Distance(playerTransform.position, birdie.transform.position);
            Debug.Log(interDistance);
            if (interDistance <= interDistanceMin){
                birdie.gameObject.SetActive(true);
                //Debug.Log(birdie);
            }
        }
    }

}
