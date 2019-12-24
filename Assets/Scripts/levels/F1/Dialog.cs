using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public GameObject Question, Answers, DialogWindow, WinWindow;
    public Button StartDialog, BA1, NA1, GA1, BA2, SA1, NA2, BA5, GA2, BA6, EA1, BA3, SA2, AA1, BA4, TA1, FA1, FA2, TA2, FA3, FA4, TA3, FA5, FA6,
        EA2, EA3, NA3, BA7, NA4, NA5, NA6, GA3, GA4, EA4, book;
    public static bool haveaheal = false;
    public bool levelisend = false;
    [SerializeField]
    Sprite stars0;
    [SerializeField]
    Sprite stars1;
    [SerializeField]
    Sprite stars2;
    [SerializeField]
    Sprite stars3;

    public void StartDialogue()
    {
        StartDialog.gameObject.SetActive(false);
        gameObject.SetActive(true);
        Question.GetComponent<Text>().text = "*Зайдя в лес Фин неожиданно встречает путника. " +
            "Он был немолод, а в его глазах можно было увидеть, что он многое знает...\nПутник с интересом смотрит на вас.*";
        BA1.gameObject.SetActive(true);
        NA1.gameObject.SetActive(true);
        GA1.gameObject.SetActive(true);
        BA1.GetComponentInChildren<Text>().text = "Слышь, дед, помоги найти дочь!";
        NA1.GetComponentInChildren<Text>().text = "Подскажи, путник, не встречал ли ты кого необычного?";
        GA1.GetComponentInChildren<Text>().text = "Здравствуй, старец. Откуда путь держишь?";
    }

    public void BA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Вам бы поучиться манерам, молодой человек.";

        BA1.gameObject.SetActive(false);
        NA1.gameObject.SetActive(false);
        GA1.gameObject.SetActive(false);
        BA2.gameObject.SetActive(true);
        SA1.gameObject.SetActive(true);


        BA2.GetComponentInChildren<Text>().text = "Ты мне мозги не трепи, старик!";
        SA1.GetComponentInChildren<Text>().text = "Извини, у меня украли дочь, поэтому я на взводе.";
    }

    public void BA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\n*Во взгляде путника сразу видно разочарование и он терят к вам какой-то бы ни было интерес.*";

        BA2.gameObject.SetActive(false);
        SA1.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);


        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }

    public void SA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + SA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nЯ помогу тебе, если ты ответишь на мои вопросы.";

        BA2.gameObject.SetActive(false);
        SA1.gameObject.SetActive(false);
        BA3.gameObject.SetActive(true);
        SA2.gameObject.SetActive(true);


        BA3.GetComponentInChildren<Text>().text = "У меня нет времени, чтобы отвечать на твои вопросы!";
        SA2.GetComponentInChildren<Text>().text = "Какие ответы ты хочешь услышать, старец?";
    }

    public void BA3b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA3.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\n*Во взгляде путника сразу видно разочарование и он терят к вам какой-то бы ни было интерес.*";

        BA3.gameObject.SetActive(false);
        SA2.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);


        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }

    public void SA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + SA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nУ меня был сын, он очень любил мои загадки. А я очень любил их ему загадывать, но несколько лет " +
            "назад он пропал. Я соскучился по загадкам. Давай я задам тебе две, а за правильные ответы ты узнаешь всё, что тебе надо.";

        BA3.gameObject.SetActive(false);
        SA2.gameObject.SetActive(false);
        AA1.gameObject.SetActive(true);
        BA4.gameObject.SetActive(true);


        AA1.GetComponentInChildren<Text>().text = "Я отвечу на твои загадки, потому что я понимаю твои чувства.";
        BA4.GetComponentInChildren<Text>().text = "У меня нет времени разгадывать твои дурацкие загадки, старик!";
    }
    public void BA4b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA4.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\n*Во взгляде путника сразу видно разочарование и он терят к вам какой-то бы ни было интерес.*";

        BA4.gameObject.SetActive(false);
        AA1.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);


        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }
    public void AA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + AA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nВот тебе моя первая загадка: все обходят это место: здесь земля как будто тесто; здесь осока " +
            "кочки, мхи. Нет опоры для ноги. Ты ответ мне свой скажи.";

        AA1.gameObject.SetActive(false);
        BA4.gameObject.SetActive(false);
        TA1.gameObject.SetActive(true);
        FA1.gameObject.SetActive(true);
        FA2.gameObject.SetActive(true);


        TA1.GetComponentInChildren<Text>().text = "Эм..это болото?";
        FA1.GetComponentInChildren<Text>().text = "Конечно же это зыбучие пески!";
        FA2.GetComponentInChildren<Text>().text = "Похоже на дороги в России.";
    }

    public void TA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + TA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nХорошо, ты молодец. Теперь настало время для второй загадки: зимой и летом одним цветом." +
            " Подумай внимательно.";

        TA1.gameObject.SetActive(false);
        FA1.gameObject.SetActive(false);
        FA2.gameObject.SetActive(false);
        TA2.gameObject.SetActive(true);
        FA3.gameObject.SetActive(true);
        FA4.gameObject.SetActive(true);


        TA2.GetComponentInChildren<Text>().text = "Ну, это может быть зомби.";
        FA3.GetComponentInChildren<Text>().text = "Какие то детские у тебя загадки, старик. Все знают, что это ёлка!";
        FA4.GetComponentInChildren<Text>().text = "Деньги.";
    }

    public void FA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nИзвини, но в этот раз ты не прав. Я задам тебе вторую загадку, ответишь на неё, получишь немного" +
            " информации: зимой и летом одним цветом. Подумай внимательно.";

        TA1.gameObject.SetActive(false);
        FA1.gameObject.SetActive(false);
        FA2.gameObject.SetActive(false);
        TA3.gameObject.SetActive(true);
        FA5.gameObject.SetActive(true);
        FA6.gameObject.SetActive(true);


        TA3.GetComponentInChildren<Text>().text = "Ну, это может быть зомби.";
        FA5.GetComponentInChildren<Text>().text = "Какие то детские у тебя загадки, старик. Все знают, что это ёлка!";
        FA6.GetComponentInChildren<Text>().text = "Деньги.";
    }

    public void FA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nИзвини, но в этот раз ты не прав. Я задам тебе вторую загадку, ответишь на неё, получишь немного" +
            " информации: зимой и летом одним цветом. Подумай внимательно.";

        TA1.gameObject.SetActive(false);
        FA1.gameObject.SetActive(false);
        FA2.gameObject.SetActive(false);
        TA3.gameObject.SetActive(true);
        FA5.gameObject.SetActive(true);
        FA6.gameObject.SetActive(true);


        TA3.GetComponentInChildren<Text>().text = "Ну, это может быть зомби.";
        FA5.GetComponentInChildren<Text>().text = "Какие то детские у тебя загадки, старик. Все знают, что это ёлка!";
        FA6.GetComponentInChildren<Text>().text = "Деньги.";
    }

    public void TA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + TA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПоздравляю тебя, оба твои ответа верные и я дам тебе две подсказки: тебе туда, о чём была первая " +
            "загадка, а ждать тебя там будет ответ на вторую загадку. А за твой ум тебе положена дополнительная награда. Вот, возьми, эта книга " +
            "спасала меня не раз в жизни, надеюсь, что она поможет и тебе.";

        haveaheal = true;

        book.gameObject.SetActive(true);
        TA2.gameObject.SetActive(false);
        FA3.gameObject.SetActive(false);
        FA4.gameObject.SetActive(false);
        EA2.gameObject.SetActive(true);


        EA2.GetComponentInChildren<Text>().text = "Спасибо тебе, старец, твоя помощь для меня неоценима.";
    }

    public void EA2b()
    {
        book.gameObject.SetActive(false);
        gameObject.SetActive(false);
        levelisend = true;
        WinWindow.gameObject.SetActive(true);
        WinWindow.GetComponent<Image>().sprite = stars2;
        GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты почти справился, но почти не считается.";
        if (LevelManager.f1endlevel == false)
        {
            PlayerStats.statspoints = 2;
        }
    }

    public void FA3b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA3.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nИзвини, но в этот раз ты не прав. Ты смог дать мне верный ответ в первый раз, за это я дам тебе " +
            "одну подсказку: тебе туда, о чём была первая загадка. А вот что тебя там ждёт - ты не узнаешь.";

        TA2.gameObject.SetActive(false);
        FA3.gameObject.SetActive(false);
        FA4.gameObject.SetActive(false);
        EA3.gameObject.SetActive(true);


        EA3.GetComponentInChildren<Text>().text = "Благодарю тебя и за это.";
    }

    public void EA3b()
    {
        gameObject.SetActive(false);
        levelisend = true;
        WinWindow.gameObject.SetActive(true);
        WinWindow.GetComponent<Image>().sprite = stars1;
        GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты прошёл уровень. Ни хорошо, ни плохо, просто прошёл.";
        if (LevelManager.f1endlevel == false)
        {
            PlayerStats.statspoints = 1;
        }
    }

    public void FA4b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA4.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nИзвини, но в этот раз ты не прав. Ты смог дать мне верный ответ в первый раз, за это я дам тебе " +
            "одну подсказку: тебе туда, о чём была первая загадка. А вот что тебя там ждёт - ты не узнаешь.";

        TA2.gameObject.SetActive(false);
        FA3.gameObject.SetActive(false);
        FA4.gameObject.SetActive(false);
        EA3.gameObject.SetActive(true);


        EA3.GetComponentInChildren<Text>().text = "Благодарю тебя и за это.";
    }

    public void FA5b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA5.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nУвы, все твои ответы оказались неверными. Ты не дал нужных мне ответов, поэтому я ничем тебе не помогу." +
            "*Во взгляде путника сразу видно разочарование и он терят к вам какой-то бы ни было интерес.*";

        TA3.gameObject.SetActive(false);
        FA5.gameObject.SetActive(false);
        FA6.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);


        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }

    public void FA6b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + FA6.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nУвы, все твои ответы оказались неверными. Ты не дал нужных мне ответов, поэтому я ничем тебе не помогу." +
            "*Во взгляде путника сразу видно разочарование и он терят к вам какой-то бы ни было интерес.*";

        TA3.gameObject.SetActive(false);
        FA5.gameObject.SetActive(false);
        FA6.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);


        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }

    public void TA3b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + TA3.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nВ этот раз ты прав. Вот тебе моя подсказка: там, куда тебе надо идти, тебе встретится ответ на вторую загадку." +
            "Больше я тебе ничего не скажу.";

        TA3.gameObject.SetActive(false);
        FA5.gameObject.SetActive(false);
        FA6.gameObject.SetActive(false);
        EA3.gameObject.SetActive(true);


        EA3.GetComponentInChildren<Text>().text = "Благодарю тебя и за это.";
    }

    public void EA1b()
    {
        gameObject.SetActive(false);
        levelisend = true;
        WinWindow.gameObject.SetActive(true);
        WinWindow.GetComponent<Image>().sprite = stars0;
        GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты, конечно, прошёл уровень, но мог бы и лучше :с";
    }

    public void NA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Я бы мог дать тебе ответ, но сначала тебе нужно дать ответ мне.";

        BA1.gameObject.SetActive(false);
        NA1.gameObject.SetActive(false);
        GA1.gameObject.SetActive(false);
        NA2.gameObject.SetActive(true);
        BA5.gameObject.SetActive(true);
        NA3.gameObject.SetActive(true);

        BA5.GetComponentInChildren<Text>().text = "У меня нет времени, чтобы давать тебе какие-то ответы.";
        NA2.GetComponentInChildren<Text>().text = "О каких ответах ты говоришь?";
        NA3.GetComponentInChildren<Text>().text = "Я был бы рад дать тебе ответ на любой вопрос, но я потерял свою дочь.";
    }

    public void BA5b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA5.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Вам бы поучиться манерам, молодой человек. *Во взгляде путника сразу видно разочарование " +
            "и он терят к вам какой-то бы ни было интерес.*";

        BA5.gameObject.SetActive(false);
        NA2.gameObject.SetActive(false);
        NA3.gameObject.SetActive(false);
        EA1.gameObject.SetActive(true);

        EA1.GetComponentInChildren<Text>().text = "Конец диалога.";
    }

    public void NA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: У меня был сын, он очень любил мои загадки. А я очень любил их ему загадывать, но несколько лет " +
            "назад он пропал. Я соскучился по загадкам. Давай я задам тебе две, а за правильные ответы ты узнаешь всё, что тебе надо.";

        NA2.gameObject.SetActive(false);
        NA3.gameObject.SetActive(false);
        BA5.gameObject.SetActive(false);
        AA1.gameObject.SetActive(true);
        BA4.gameObject.SetActive(true);

        AA1.GetComponentInChildren<Text>().text = "Я отвечу на твои загадки, потому что я понимаю твои чувства.";
        BA4.GetComponentInChildren<Text>().text = "У меня нет времени разгадывать твои дурацкие загадки, старик!";
    }

    public void NA3b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA3.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Так ты потерял свою дочь? Я потерял сына несколько лет назад";

        NA2.gameObject.SetActive(false);
        NA3.gameObject.SetActive(false);
        BA5.gameObject.SetActive(false);
        BA7.gameObject.SetActive(true);
        NA4.gameObject.SetActive(true);

        BA7.GetComponentInChildren<Text>().text = "Я же сказал, мне некогда, не начинай свою историю.";
        NA4.GetComponentInChildren<Text>().text = "Мне жаль тебя, но это значит, что ты меня понимаешь. Так помоги мне.";
    }

    public void BA7b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA7.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Вам бы поучиться манерам, молодой человек.";

        BA7.gameObject.SetActive(false);
        NA4.gameObject.SetActive(false);
        BA2.gameObject.SetActive(true);
        SA1.gameObject.SetActive(true);


        BA2.GetComponentInChildren<Text>().text = "Ты мне мозги не трепи, старик!";
        SA1.GetComponentInChildren<Text>().text = "Извини, у меня украли дочь, поэтому я на взводе.";
    }

    public void NA4b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA4.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Хорошо, я помогу тебе. Но ты не захотел отвечать на мои вопросы, так что всё, что я могу тебе " +
            "сказать - тебе туда, где твоим ногам будет тяжело стоять.";

        BA7.gameObject.SetActive(false);
        NA4.gameObject.SetActive(false);
        BA5.gameObject.SetActive(false);
        EA3.gameObject.SetActive(true);


        EA3.GetComponentInChildren<Text>().text = "Благодарю тебя и за это.";
    }

    public void GA1b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + GA1.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: И тебе здравствуй. Я возвращаюсь с дальних земель, с поисков моего сына. " +
            "Мой сын был прекрасным человеком, пока не достиг 18-летия, после этого его как будто подменили. Из хорошего мальчика он превратился в молодого" +
            "парня безумно желающего власти. Когда он встретил свою жену, я думал, что он изменится, но ни она, ни их общий ребенок не помогли." +
            "В итоге он ушел, никто не знал, куда, зачем и точно времени и дня его ухода. Я в то время был в путешствие, вернувшись домой, никого там" +
            "не застал. Оказалось, что жена моего сына погибла при родах, а моя внучка и сын пропали. Я не смог с этим смириться и отправился на поиски." +
            "Несколько лет я пытался их найти, многое повидал, много, кто встретил, но так и не нашёл ни сына, ни внучку. Я отчаялся и теперь возвращаюсь домой.";

        BA1.gameObject.SetActive(false);
        NA1.gameObject.SetActive(false);
        GA1.gameObject.SetActive(false);
        GA2.gameObject.SetActive(true);
        BA6.gameObject.SetActive(true);
        NA5.gameObject.SetActive(true);

        GA2.GetComponentInChildren<Text>().text = "Судя по твоей истории, ты сможешь меня понять. У меня похитили дочь. Ты видел многое, так " +
            "может ты и её встречал?";
        BA6.GetComponentInChildren<Text>().text = "Я спросил тебя о том, откуда ты идёшь, а не о твоей истории, старик!";
        NA5.GetComponentInChildren<Text>().text = "Мне жаль тебя, но мне очень нужна информация. Помоги мне.";
    }

    public void BA6b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + BA6.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Вам бы поучиться манерам, молодой человек.";

        BA6.gameObject.SetActive(false);
        NA5.gameObject.SetActive(false);
        GA2.gameObject.SetActive(false);
        BA2.gameObject.SetActive(true);
        SA1.gameObject.SetActive(true);


        BA2.GetComponentInChildren<Text>().text = "Ты мне мозги не трепи, старик!";
        SA1.GetComponentInChildren<Text>().text = "Извини, у меня украли дочь, поэтому я на взводе.";
    }
    public void NA5b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA5.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Мой сын любил загадки. За ответы на них я могу дать тебе информацию.";

        BA6.gameObject.SetActive(false);
        NA5.gameObject.SetActive(false);
        GA2.gameObject.SetActive(false);
        AA1.gameObject.SetActive(true);
        BA4.gameObject.SetActive(true);


        AA1.GetComponentInChildren<Text>().text = "Я отвечу на твои загадки, потому что я понимаю твои чувства.";
        BA4.GetComponentInChildren<Text>().text = "У меня нет времени разгадывать твои дурацкие загадки, старик!";
    }

    public void GA2b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + GA2.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Так вот почему ты выглядишь так взволновано. Я понимаю, родителям тяжело переживать о чём-то " +
            "связанном с их детьми. Мне было очень тяжело все эти годы и сейчас тяжело. Что-то я разболтался, ты веждь ждешь от меня ответов. Что ж, ты " +
            "можешь сказать что-то более подробное? Тогда, возможно, я тебе помогу.";

        BA6.gameObject.SetActive(false);
        NA5.gameObject.SetActive(false);
        GA2.gameObject.SetActive(false);
        NA6.gameObject.SetActive(true);
        GA3.gameObject.SetActive(true);


       NA6.GetComponentInChildren<Text>().text = "Прошу, я просто хочу получить ответы. Некогда рассказывать истории.";
       GA3.GetComponentInChildren<Text>().text = "Это случилось около суток назад. Это был обычный весенний день, как вдруг началась снежная буря." +
            "Моей дочери не было дома. Когда я её увидел, с ней стояла мрачная, холодная фигура. А моя дочь " +
            "была в фиолетовом плаще и белом платье и у неё голубые глаза.";
    }

    public void NA6b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + NA6.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Хорошо, я помогу тебе. Но ты не захотел отвечать на мои вопросы, так что всё, что я могу тебе " +
            "сказать - тебе туда, где твоим ногам будет тяжело стоять.";

        NA6.gameObject.SetActive(false);
        GA3.gameObject.SetActive(false);
        EA3.gameObject.SetActive(true);


        EA3.GetComponentInChildren<Text>().text = "Благодарю тебя и за это.";
    }

    public void GA3b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + GA3.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Ты рассказывал это с болью в сердце, я понимаю тебя. Я чувствовал себя также, когда пропал мой сын." +
            "А я даже не знал, что с ним случилось. Может он просто ушёл по своей воле? А ты вид похищение своего дитя, это ужасно. За твою открытость и" +
            "вежливость, скажу тебе всё также честно: отправляйся в болоте, но будь осторожен, там тебя будут поджидать зомби.";

        NA6.gameObject.SetActive(false);
        GA3.gameObject.SetActive(false);
        GA4.gameObject.SetActive(true);


        GA4.GetComponentInChildren<Text>().text = "Благодарю тебя, старец. И сочувствую твоей утрате, как своей. Я верю, что с твоим сыном и внучкой всё хорошо." +
            "А мне ты оказал неоценимую помощь.";
        
    }

    public void GA4b()
    {
        Question.GetComponent<Text>().text += "\n\nФин: " + GA4.GetComponentInChildren<Text>().text;
        Question.GetComponent<Text>().text += "\n\nПутник: Подожди, это не всё. Вот, возьми, эта книга " +
            "спасала меня не раз в жизни, надеюсь, что она поможет и тебе. Пусть хоть один из нас найдёт своего ребёнка.";

        GA4.gameObject.SetActive(false);
        EA4.gameObject.SetActive(true);
        book.gameObject.SetActive(true);

        haveaheal = true;

        EA4.GetComponentInChildren<Text>().text = "Ещё раз спасибо тебе. Я обязательно найду свою дочь.";

    }

    public void EA4b()
    {
        book.gameObject.SetActive(false);
        gameObject.SetActive(false);
        levelisend = true;
        WinWindow.gameObject.SetActive(true);
        WinWindow.GetComponent<Image>().sprite = stars3;
        GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Вот это да. Ты безупречно прошёл уровень с:";
        if (LevelManager.f1endlevel == false)
        {
            PlayerStats.statspoints = 3;
        }
    }

    public void bookdesc()
    {
        book.GetComponentInChildren<Text>().text = "Книга выглядит довольно потрёпанной. Видно, что она повидала немало вместе со своим " +
            "предыдущим хозяином. От книга веет теплом и прикосновении к ней она чувствуется, как она наполняет Фина жизненной силой.";
    }











































}
