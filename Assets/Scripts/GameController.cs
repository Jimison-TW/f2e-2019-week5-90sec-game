using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;
    public Timer timer;
    public BGController bgControl;
    public ObjectCreator creator;
    public Inspector inspector;
    public MessageBox messageBox;

    private UnityAction onTimeupAction;
    private UnityAction onGameOverAction;
    private UnityAction onBumpWeaponAction;
    private UnityAction onBumpBlockAction;

    // Start is called before the first frame update
    void Start()
    {
        onTimeupAction += onTimeup;
        timer.setTimeupAction(onTimeupAction);
        onBumpBlockAction += onBumpBlock;
        onBumpWeaponAction += onBumpWeapon;
        player.setAction(onBumpWeaponAction, onBumpBlockAction);
        onGameOverAction += onGameOver;
        inspector.setGameOverAction(onGameOverAction);
    }

    private void onTimeup()
    {
        timer.stopTimer();
        creator.stopCreator();
        player.gameObject.GetComponent<Collider2D>().enabled = false;
        bgControl.completeGame();
        messageBox.showMessage("恭喜你完成遊戲，是否從新開始遊戲?");
    }

    private void onBumpBlock()
    {
        inspector.loseLife();
    }

    private void onBumpWeapon()
    {
        inspector.addLife();
    }

    private void onGameOver()
    {
        creator.stopCreator();
        player.gameObject.GetComponent<Collider2D>().enabled = false;
        bgControl.stopScroll();
        timer.stopTimer();
        messageBox.showMessage("是否從新開始遊戲?");
    }

    public void restartGame(){
        SceneManager.LoadScene("SampleScene");
    }
}
