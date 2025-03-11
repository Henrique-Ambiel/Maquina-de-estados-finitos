// Interface que define os m�todos que todos os estados devem implementar
public interface IState
{
    // M�todo chamado quando o estado � ativado ou iniciado
    void OnEnter();

    // M�todo chamado a cada frame durante o estado, que retorna o pr�ximo estado
    StateMachine.EState OnUpdate();

    // M�todo chamado quando o estado � desativado ou terminado
    void OnExit();
}
