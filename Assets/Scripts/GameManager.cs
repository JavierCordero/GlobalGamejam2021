using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //UI
    [Header("Textos de la escena")]
    public Text timerText;              //Esto igual ni va aquí
    public Text puntosP1Text;           //Puntos p1
    public Text puntosP2Text;           //Puntos p2
    public GameObject panelPausa;       //Panel de la pausa
    public Slider volumeSlide;       //Panel de la pausa

    //Gestión del tiempo
    [Header("Tiempo para Objetivo")]
    public float minutesToGetObjective = 5;
    public float secondsToGetObjective = 1;

    //Multiplayer
    [Header("Multiplayer")]
    public bool IsMultiplayer = false;

    //Random Objectives
    [Header("Settings Objetivos")]
    public float numObjetivos = 5;
    public Transform posicionObjetivoCanvas;        //Posición en el mundo que va a tener el objeto canvas
    public bool RandomObjectives = true;
    public float distanciaMinimaEntreObjetivos = 3;

    //Props Objetivo
    [SerializeField]
    private List<ObjectiveProp> _objectiveProps;    //Ahora mismo es de objetivos, pero será de puntos de spawn
    private ObjectiveProp _currentObjective;
    private ObjectiveProp _canvasObjective;
    private int _objectiveIndex;    //Indice en la lista de objetivos en caso de no ser aleatorio

    //Puntos
    private int puntosP1 = 0;
    private int puntosP2 = 0;

    //Timer en segundos
    private float _currentTimer;


    //Patrón singleton de toda la vida
    public static GameManager instance;
    private bool _isPaused;


    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            instance = this;
            SetUp();
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject);
    }


    void SetUp()
    {
        _objectiveProps = new List<ObjectiveProp>();
        _currentTimer = secondsToGetObjective + (minutesToGetObjective * 60);
        puntosP1 = puntosP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Si no tengo objetivo, selecciono uno
        if (_currentObjective == null) SetNewObjective();
        else
        {
            if (!IsMultiplayer)
            {
                //Timer singleplayer
                if (_currentTimer >= 0)
                {
                    _currentTimer -= Time.deltaTime;
                    int minutes = (int)_currentTimer / 60;              //Get total minutes
                    int seconds = (int)_currentTimer - (minutes * 60);  //Get seconds for display alongside minutes
                    if (timerText)
                        timerText.text = "TIEMPO: " + minutes.ToString("D2") + ":" + seconds.ToString("D2");
                }
                else
                {
                    OnGameOver();
                }
            }
        }
    }

    public void AddNewObjectiveProp(ObjectiveProp prop)
    {
        _objectiveProps.Add(prop);
        //Debug.Log("added a prop: " + prop.name + "\ncount: " + _objectiveProps.Count);
    }

    public void SetNewObjective()
    {
        if (_objectiveProps.Count > 0)
        {
            if (RandomObjectives)
            {
                bool stop = false;
                int sameDistanceCount = 0; //Para evitar while-trues
                while (!stop)
                {
                    int rnd = Random.Range(0, _objectiveProps.Count);
                    if (_currentObjective != null)
                    {
                        float dist = Vector3.Distance(_currentObjective.transform.position, _objectiveProps[rnd].transform.position);
                        if (dist > distanciaMinimaEntreObjetivos || sameDistanceCount == _objectiveProps.Count)
                        {
                            _currentObjective = _objectiveProps[rnd];
                            stop = true;
                        }
                        else sameDistanceCount++;
                    }
                    //Si es null, me sirve cualquiera
                    else _currentObjective = _objectiveProps[rnd];

                }
                //Setup del objetivo en el canvas
                ObjectiveCanvasCopySetUp();


            }

            //Iterativo, deprecadisimo
            else
            {
                _objectiveIndex++;
                _currentObjective = _objectiveProps[_objectiveIndex];
            }

            //Establecemos el objetivo en el objeto
            _currentObjective.SetAsCurrentObjective();
            Debug.LogWarning("CURRENT OBJECTIVE: " + _currentObjective);
        }
    }

    public void OnObjectiveCollected(ObjectiveProp collectedProp, PlayerInformation playerInfo)
    {
        Debug.Log("Objetivo conseguido :)");
        _objectiveProps.Remove(collectedProp);

        //Sumar tiempo o lo que sea
        if (playerInfo._myPlayerNumber == myPlayerNumber.Player1)
        {
            puntosP1++;
            if(puntosP1Text)
                puntosP1Text.text = "P1: " + puntosP1.ToString("D2");
        }
        else if (playerInfo._myPlayerNumber == myPlayerNumber.Player2)
        {
            puntosP2++;
            if(puntosP2Text)
                puntosP2Text.text = "P2: " + puntosP2.ToString("D2");

        }

        numObjetivos--;
        if (numObjetivos <= 0)
        {
            OnGameOver();
        }
        else SetNewObjective();
    }

    public bool IsRandomMode() { return RandomObjectives; }


    /// <summary>
    /// Método que es llamado cuando termina el juego
    /// </summary>
    void OnGameOver()
    {
        Debug.Log("Game over!");
        //Ir al menú de resultados, o lo que sea
    }

    public void OnTogglePause()
    {
        _isPaused = !_isPaused;
        if (_isPaused)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;

        panelPausa.SetActive(_isPaused);

    }

    public void OnGameExit()
    {
        //TODO: Cambia a la escena de menú, que ni idea de cuál es
        Debug.LogWarning("Closing game...");
    }

    public void OnVolumeChange()
    {
        float volumen = volumeSlide.value;
        //Wow mira soy una canción voy a ajustar mi volumen xdd
        Debug.Log("Volumen: " + volumen);
    }

    private void ObjectiveCanvasCopySetUp()
    {
        //Spawn de una copia del objeto en el área de objetivo del Canvas
        ObjectiveProp old = _canvasObjective;

        _canvasObjective = Instantiate(_currentObjective, posicionObjetivoCanvas);

        _canvasObjective.gameObject.transform.localPosition = new Vector3(0, 0, 0); //creeme, es así
        _canvasObjective.gameObject.transform.localScale = new Vector3(1.3F, 1.3F, 1.3F);
        _canvasObjective.gameObject.transform.Rotate(new Vector3(0, 0));

        _canvasObjective.GetComponent<Rigidbody>().isKinematic = true;
        _canvasObjective.GetComponent<ObjectiveProp>().enabled = false; //Importante, para que no salga como posible objetivo 
        _canvasObjective.GetComponent<InteractableObject>().enabled = false;

        if (old != null)
        {
            Destroy(old.gameObject);
        }

    }
}
