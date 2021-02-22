using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class BackButton : MonoBehaviour
{
    public float time;
    public AudioSource AudioSource;
    public Animator Animation;
   public void Back()
    {
        StartCoroutine(Away());
        Debug.Log("Back");
        AudioSource.Play();
        
    }

    IEnumerator Away()
    {

        Animation.SetTrigger("Trigger");

        yield return new WaitForSeconds(time);

        SceneManager.LoadSceneAsync(0);
    }

    public void Level1()
    {

        SceneManager.LoadScene(1);
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(2);
    }
    /* Verse 1:
   It's not FlingSmash, Geist, or Burnout Crash
   Not Mario Party 6 or Ultra Smash
   Neither Clubhouse Games or Wii Fit Plus
   Nor Family Feud on SN-US

   All the games I play, whether good or bad
   Have troupes in common, my favorite do-dads
   It may be rushed, or plain, or flawed
   But they ain't RPG's
   Oh, thank God!

   Pre-Chorus:
   Are my tastes just bad?
   Am I the one to blame?
   Or is it RPG's that are DUMB and LAME?
   No!

   Chorus:
   Why don't you play them?
   They just take so damn long to complete
   Why don't you play them?
   60 hours, just to rinse and repeat
   But you'll just grind for years to beat that boss, oh
   Why waste all this time on just one game?

   Break:
   Why don't you play them?
   I just don’t like them!
   I just wanna play stupid Nintendo games, that aren’t that stupid!
   Why don’t I like them? Okay!

   Verse 2:
   Turn-based battles and too much text
   I'd rather be out not having sex
   Menu clutter and useless stats
   And random encounters can kiss my ass!

   No gameplay till hours in
   Combat-ready! How did I win?
   The same thing happens over again
   And then the fun part comes up when?

   Verse 3:
   I miss one thing, and now I'm lost
   That one inch of text really meant a lot?
   Some shop with items, I can't afford
   So grind for money, you won't be bored!
   I'm tired, I'm scared, I'm not having fun
   There's no other way this can be spun
   What do I do? What do I check?
   It's an RPG, what did I expect?

   Ending:
   Why don't you play them?
   They're so good, that you can't have opinions (Listen guys)
   Why don't you play them?
   (They're not my style!)
   Start a new file
   Why don't you, why-why-why don't you*/
}

