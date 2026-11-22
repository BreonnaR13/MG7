# MG7
## Devlog
Write your Devlog here. :3

In the TreeOfBirds script there is one method which is the update method. Within Update() there is a for loop used to iterate through the array which is a list of all the bird game objects in the game. The birds were added into the array through the inspector. Using an array allows for us to not have to write separate code for each bird. In the for loop, each time it runs, one bird in the list is checked to see if its distance away from the player character is less than the largest distance they have to be for the sparrow to appear. I did this by using Vector3.Distance and put in the position of the bird, from the array that the for loop is on, and the position of the player. The positions are stored as Vector3s so we are using vectors to find the distance between the two game objects. Then I used an if statement to see if that distance is less than or equal to the max distance the player can be away from the bird to trigger it popping out. If the distance is less than or equal to that amount, then the bird game object is set to active using SetActive.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
