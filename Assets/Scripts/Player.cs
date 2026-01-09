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
        // don't forget about Time.deltaTime
        if ((Input.GetKey(KeyCode.W) ))
        {
            _playerTransform.Translate(Vector2.up*Time.deltaTime);
        }
        else if ((Input.GetKey(KeyCode.A) ))
        {
            _playerTransform.Translate(Vector2.left*Time.deltaTime);
        }
        else if((Input.GetKey(KeyCode.S) ))
        {
            _playerTransform.Translate(Vector2.down*Time.deltaTime);
        }
        else if ((Input.GetKey(KeyCode.D) ))
        {
            _playerTransform.Translate(Vector2.right*Time.deltaTime);
        }

 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsLeft > 0)
            {
                PlantSeed();
            }
        
        }
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab,transform.position, transform.rotation);
        _numSeedsPlanted++;
        _numSeedsLeft--;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
