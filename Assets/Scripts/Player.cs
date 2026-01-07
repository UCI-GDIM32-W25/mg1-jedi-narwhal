using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft=_numSeeds;
    }

    private void Update()
    {
 
        if ((Input.GetKey(KeyCode.W) ))
        {
            _playerTransform.Translate(Vector2.up);
        }
        else if ((Input.GetKey(KeyCode.A) ))
        {
            _playerTransform.Translate(Vector2.left);
        }
        else if((Input.GetKey(KeyCode.S) ))
        {
            _playerTransform.Translate(Vector2.down);
        }
        else if ((Input.GetKey(KeyCode.D) ))
        {
            _playerTransform.Translate(Vector2.right);
        }

 
        if (Input.GetKeyDown(KeyCode.Space))
        {

            PlantSeed();
        
        }
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab,transform.position, transform.rotation);
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
