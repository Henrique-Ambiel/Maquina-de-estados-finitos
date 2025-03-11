using UnityEngine;

// Classe que implementa o estado de patrulha, que segue a interface IState
public class Patrol : IState
{
    // Construtor da classe Patrol. Ele recebe um Rigidbody e um array de pontos de patrulha (waypoints).
    // Esses par�metros s�o atualmente n�o utilizados, mas podem ser usados para controlar o movimento do agente.
    public Patrol(Rigidbody rigidbody, Vector3[] wayPoints) { }

    // M�todo chamado quando o estado de patrulha � ativado
    public void OnEnter()
    {
        // Aqui voc� pode adicionar l�gica para inicializar o estado de patrulha,
        // como configurar o agente para come�ar a patrulhar ou tocar uma anima��o de patrulha.
    }

    // M�todo chamado quando o estado de patrulha � desativado ou trocado
    public void OnExit()
    {
        // Aqui voc� pode adicionar l�gica para finalizar o estado de patrulha,
        // como parar a anima��o ou limpar recursos relacionados ao estado de patrulha.
    }

    // M�todo chamado a cada frame enquanto o estado de patrulha est� ativo.
    // Ele retorna o pr�ximo estado que a m�quina de estados deve mudar para.
    public StateMachine.EState OnUpdate()
    {
        // Neste caso, o agente permanece no estado de patrulha e n�o muda para outro estado.
        // Aqui pode ser adicionada a l�gica para mover o agente entre os waypoints, 
        // mas por enquanto, ele sempre retorna o mesmo estado de patrulha.
        return StateMachine.EState.Patrol;
    }
}
