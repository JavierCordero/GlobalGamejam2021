using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Requerimos el RigidBoy para poder mover el objeto
[RequireComponent(typeof(Rigidbody))]

public class EarthquakeComponent : MonoBehaviour
{
    //SETTINGS 
    [Header("Settings")]

    [Tooltip("Objeto que va a recibir el shake")]
    public GameObject EarthquakeTarget = null;

    [Tooltip("Fuerza con la que se mueve el suelo")]
    [Range(0f, 2f)]
    public float shakeForce = 0.5f;

    [Tooltip("Duración total del temblor en segundos")]
    [Range(0f, 2f)]
    public float shakeDuration = 1f;

    //COOLDOWN
    [Header("Cooldown")]
    [Tooltip("Tiempo que espera antes de preguntar el random")]
    [Range(0f, 10f)]
    public float shakeCooldown = 1f;

    [Tooltip("Probabilidad de aparición de un terremoto tras el cooldown")]
    [Range(0f, 100f)]
    public float shakeProbability = 100f;

    //CÁMARA
    [Header("Camera shake")]
    [Tooltip("Duración de shake de las cámara")]
    public float _cameraShakeDuration = 2f;

    [Tooltip("Fuerza de shake de las cámara")]
    public float _cameraShakeForce = 0.10f;

    //PRIVADO
    private float _timer;                                       //Timer interno de la duración de los temblores
    private float _cooldownTimer;                               //Timer interno del cooldown de los temblores
    private Vector3 _startPos;                                  //Posición inicial
    private Vector3 _randomPos;                                 //Posición aleatoria que se le va dando al suelo

    private PlayerInput _playerInput;

    //TODO: de qué camara se coge?
    private CameraShakeComponent _cameraShake;


    // Start is called before the first frame update
    void Start()
    {
        if (!EarthquakeTarget)
        {
            Debug.LogError("No existe ningún objeto para hacer Earthquake");
            return;
        }
        _startPos = EarthquakeTarget.transform.position;
        _cameraShake = Camera.main.GetComponent<CameraShakeComponent>();

        _playerInput = FindObjectOfType<PlayerInput>();
    }

    public void Update()
    {
        if (_cooldownTimer <= 0)
        {
            _cooldownTimer -= Time.deltaTime;
        }
    }

    public void StartEarthquake()
    {

        if (_cooldownTimer <= 0)
        {
            float prob = shakeProbability / 100;
            float rnd = Random.Range(0, 1);
            if (rnd <= prob)
            {
                _playerInput._powerUpEnabled = false;
                StartCoroutine(_cameraShake.Shake(_cameraShakeDuration, _cameraShakeForce));
                BeginShake();
            }
            else { 
                _cooldownTimer = shakeCooldown; 
            }
        }
    }


    /// <summary>
    /// Hace un shake del objeto al que está asignado mediante la corroutina Shake
    /// </summary>
    public void BeginShake()
    {
        StopAllCoroutines();
        StartCoroutine(Shake());
    }

    /// <summary>
    /// Mueve el objeto colocandolo en una posición aleatoria dentro de un área circular alrededor del centro del objeto que posee este componente.
    /// El temblor continúa durante la duración total establecida.
    /// Si se desean intervalos esos intervalos NO están dentro del tiempo total del movimiento, sino que son independientes.
    /// </summary>
    /// <returns>No devuelve nada</returns>
    private IEnumerator Shake()
    {
        _timer = 0f;
        while (_timer < shakeDuration)
        {
            _timer += Time.deltaTime;
            _randomPos = _startPos + (Random.insideUnitSphere * shakeForce); //Coloco el objeto en una posición aleatoria de un área de tamaño "proporcional a la fuerza"
            EarthquakeTarget.transform.position = _randomPos;


            yield return null;

        }

        //Volvemos a poner el suelo donde estaba
        EarthquakeTarget.transform.position = _startPos;

        _cooldownTimer = shakeCooldown;
    }

}
