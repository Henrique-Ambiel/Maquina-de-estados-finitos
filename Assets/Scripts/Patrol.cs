using UnityEngine;

// Classe que implementa o estado de patrulha, que segue a interface IState
public class Patrol : IState
{
    // Construtor da classe Patrol. Ele recebe um Rigidbody e um array de pontos de patrulha (waypoints).
    // Esses parâmetros são atualmente não utilizados, mas podem ser usados para controlar o movimento do agente.
    public Patrol(Rigidbody rigidbody, Vector3[] wayPoints) { }

    // Método chamado quando o estado de patrulha é ativado
    public void OnEnter()
    {
        // Aqui você pode adicionar lógica para inicializar o estado de patrulha,
        // como configurar o agente para começar a patrulhar ou tocar uma animação de patrulha.
    }

    // Método chamado quando o estado de patrulha é desativado ou trocado
    public void OnExit()
    {
        // Aqui você pode adicionar lógica para finalizar o estado de patrulha,
        // como parar a animação ou limpar recursos relacionados ao estado de patrulha.
    }

    // Método chamado a cada frame enquanto o estado de patrulha está ativo.
    // Ele retorna o próximo estado que a máquina de estados deve mudar para.
    public StateMachine.EState OnUpdate()
    {
        // Neste caso, o agente permanece no estado de patrulha e não muda para outro estado.
        // Aqui pode ser adicionada a lógica para mover o agente entre os waypoints, 
        // mas por enquanto, ele sempre retorna o mesmo estado de patrulha.
        return StateMachine.EState.Patrol;
    }
}
