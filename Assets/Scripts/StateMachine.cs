using UnityEngine;

public class StateMachine : MonoBehaviour
{
    // Definindo os estados poss�veis para a m�quina de estados
    public enum EState { Patrol, Chase };

    // Vari�vel para armazenar o estado atual da m�quina de estados
    private EState currentState;

    // Array para armazenar as inst�ncias dos estados (Patrol e Chase)
    private IState[] states;

    // M�todo chamado quando o script � iniciado
    void Start()
    {
        // Inicializando o array de estados com as inst�ncias de Patrol e Chase
        states = new IState[]
        {
            new Patrol(null, null), // Estado de patrulha
            new Chase(null, null)   // Estado de persegui��o
        };
    }

    // M�todo chamado a cada frame
    void Update()
    {
        // Chama o m�todo OnUpdate do estado atual e obt�m o pr�ximo estado
        EState nextState = states[(int)currentState].OnUpdate();

        // Verifica se o pr�ximo estado � diferente do estado atual
        if (currentState != nextState)
        {
            // Chama o m�todo OnExit do estado atual para sair do estado atual
            states[(int)currentState].OnExit();

            // Chama o m�todo OnEnter do pr�ximo estado para entrar no novo estado
            states[(int)nextState].OnEnter();

            // Atualiza o estado atual para o pr�ximo estado
            currentState = nextState;
        }
    }
}
