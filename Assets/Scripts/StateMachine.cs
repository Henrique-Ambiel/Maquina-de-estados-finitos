using UnityEngine;

public class StateMachine : MonoBehaviour
{
    // Definindo os estados possíveis para a máquina de estados
    public enum EState { Patrol, Chase };

    // Variável para armazenar o estado atual da máquina de estados
    private EState currentState;

    // Array para armazenar as instâncias dos estados (Patrol e Chase)
    private IState[] states;

    // Método chamado quando o script é iniciado
    void Start()
    {
        // Inicializando o array de estados com as instâncias de Patrol e Chase
        states = new IState[]
        {
            new Patrol(null, null), // Estado de patrulha
            new Chase(null, null)   // Estado de perseguição
        };
    }

    // Método chamado a cada frame
    void Update()
    {
        // Chama o método OnUpdate do estado atual e obtém o próximo estado
        EState nextState = states[(int)currentState].OnUpdate();

        // Verifica se o próximo estado é diferente do estado atual
        if (currentState != nextState)
        {
            // Chama o método OnExit do estado atual para sair do estado atual
            states[(int)currentState].OnExit();

            // Chama o método OnEnter do próximo estado para entrar no novo estado
            states[(int)nextState].OnEnter();

            // Atualiza o estado atual para o próximo estado
            currentState = nextState;
        }
    }
}
