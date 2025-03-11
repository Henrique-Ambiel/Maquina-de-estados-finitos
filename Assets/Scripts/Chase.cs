using UnityEngine;

// Classe que implementa o estado de persegui��o (Chase), seguindo a interface IState
public class Chase : IState
{
    // Construtor da classe Chase. Recebe um Rigidbody e um array de pontos de patrulha (waypoints).
    // Esses par�metros n�o s�o usados diretamente, mas podem ser necess�rios para controlar o movimento do agente.
    public Chase(Rigidbody rigidbody, Vector3[] wayPoints) { }

    // M�todo chamado quando o estado de persegui��o � ativado
    public void OnEnter()
    {
        // Aqui voc� pode adicionar l�gica para inicializar o estado de persegui��o,
        // como configurar o agente para come�ar a perseguir um alvo ou tocar uma anima��o de persegui��o.
    }

    // M�todo chamado quando o estado de persegui��o � desativado ou trocado
    public void OnExit()
    {
        // Aqui voc� pode adicionar l�gica para finalizar o estado de persegui��o,
        // como parar a anima��o ou limpar recursos relacionados ao estado de persegui��o.
    }

    // M�todo chamado a cada frame enquanto o estado de persegui��o est� ativo.
    // Ele retorna o pr�ximo estado que a m�quina de estados deve mudar para.
    public StateMachine.EState OnUpdate()
    {
        // Neste exemplo, o agente permanece no estado de persegui��o e n�o muda para outro estado.
        // Esse m�todo poderia, por exemplo, verificar se o agente alcan�ou o alvo e, ent�o, mudar para outro estado,
        // mas por enquanto, ele sempre retorna o estado de persegui��o.
        return StateMachine.EState.Chase;
    }
}
