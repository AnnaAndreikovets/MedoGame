INCLUDE globals.ink
VAR poisoning = 0
->Main
===Main===
Что-то хотели? Все какие-то встревоженные...#portrait:1 #speaker:Анжела
*Будет приятно представится. Меня зовут Саймон Брендль и я работаю детективом. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1
->Path1
* Обойдёмся без изяществ. Меня зовут Саймон Брендль и я работаю детективом. #speaker:Саймон #portrait:3
->Path1
=Path1
Рада завести новое знакомство. #portrait:1 #speaker:Анжела
*Уделите мне минутку, мисс? #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1
Да, конечно. #portrait:1 #speaker:Анжела
->Path2
*Отложите все дела: мне надо с вами поговорить. #speaker:Саймон #portrait:3
И что же вы хотели? #portrait:1 #speaker:Анжела
->Path2
=Path2
*Мне нужно задать вам несколько вопросов. #speaker:Саймон #portrait:3
*Я бы хотел, что бы вы ответили на некоторые мои вопросы, если не возражаете. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1
-И по какому это поводу? #portrait:1 #speaker:Анжела
->Path6
=Path3
...
*Можете расписать распорядок вашего дня? #speaker:Саймон #portrait:3
Меня разбудила горничная. Затем пошла завтракать. Сразу после этого я удалилась к себе. Ближе к обеду, примерно за час - полтора, направилась в комнату отдыха. #portrait:1 #speaker:Анжела 
В том месте я столкнулась с Алексом. Он заинтересовал меня и увлёк беседой. Он ушёл, а я так там и осталась. Примерно через минуту - две раздался крик девушки.
Я решила, что это пустяки и проигнорировала его.
->Path3
*Вы знакомы с Мартином Журтэком? #speaker:Саймон #portrait:3
Нет. #portrait:1 #speaker:Анжела
->Path3
*Почему для отдыха вы выбрали именно это место? #speaker:Саймон #portrait:3
Я наткнулась на него, когда сёрфила в интернете. Оно показалось мне умиротворённым и спокойным, а именно такое я и искала, что бы отдохнуть. #portrait:1 #speaker:Анжела
->Path3
*Вы видели что-нибудь подозрительное? #speaker:Саймон #portrait:3
Однозначно нет. #portrait:1 #speaker:Анжела
->Path3
 + -> Path8
=Path4
... #portrait:1 #speaker:Анжела
*[На счёт инцидента могу  сказать лишь, то что это был Мартин Журтэк.]
На счёт инцидента могу  сказать лишь, то что это был Мартин Журтэк. Проявите понимание: о большем сказать не могу. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1
-> Path5
=Path5
Готова сотрудничать, если вы поделитесь большим количеством информации. #portrait:1 #speaker:Анжела
*Кто вы собственно? #speaker:Саймон #portrait:3
Меня зовут Анжела Куперская, моя сфера - журналистика. Моё везение или проклятие - я всегда оказываюсь первой около мест происшествий и урываю куски свеженькой информации. #portrait:1 #speaker:Анжела
**Вы должны понимать, что я не могу рассказать о большем. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela - 1
Ладно. Спрашивайте. Но не ждите от меня большого отклика.  #portrait:1 #speaker:Анжела
**Буду рад если мы поможем друг-дуру. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1 
~agreementShare = 1
Приятно слышать. #portrait:1 #speaker:Анжела
- + ->Path3
=Path6
**Думаю, что вам не стоит знать. #speaker:Саймон #portrait:3
Если не стоит знать, то и не стоит отвечать. #portrait:1 #speaker:Анжела
***Я настаиваю на этом. #speaker:Саймон #portrait:3
Ладно, вы меня заинтриговали. Если вопросы покажутся мне неуместными, то я не стану отвечать. Спрашивайте. #portrait:1 #speaker:Анжела
->Path3
***Один из постояльцев был найден мёртвым. #speaker:Саймон #portrait:3
Мёртвым? Когда? Его убили? Если да, то уже есть подозреваемые? Почему вы расследуете это дело? #portrait:1 #speaker:Анжела
->Path4
**Произошёл кое-какой инцидент. #speaker:Саймон #portrait:3
Да? Звучит интригующе. Неужели убийство? #portrait:1 #speaker:Анжела
***К сожалению похоже на то. #speaker:Саймон #portrait:3
->Path5
***Извините, я не могу вам сказать больше. Даже не пытайтесь выведать. #speaker:Саймон #portrait:3
Ладно. Спрашивайте. #portrait:1 #speaker:Анжела
->Path3
***Не ваше дело, что произошло. Вы обязаны ответить на вопросы и не юлите. #speaker:Саймон #portrait:3
Зачем так грубить? Вы должны понимать, что девушкам такое не нравится. Что ж, спрашивайте всё, что вы там хотели. #portrait:1 #speaker:Анжела
~relationshipAnzela = relationshipAnzela - 2
->Path3
=Path7
* Спасибо за компанию и содействие. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela + 1
-> END
* Надеюсь, что вы ничего не утаили. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela - 1
->END
* Хоть и произошло убийство, время прибывания здесь обещает быть одним из самых приятных. #speaker:Саймон #portrait:3
   Почему же?  #portrait:1 #speaker:Анжела
    ** Отдохну от городской суеты. #speaker:Саймон #portrait:3
    Как же я вас понимаю.#portrait:1 #speaker:Анжела
    ---***До скорого. ->END
    ** [Из-за вас.] Я проведу его с самой прекрасной дамой на свете.  #speaker:Саймон #portrait:3
    Я не из той категории девушек падких на лесть.#portrait:1 #speaker:Анжела
    ~relationshipAnzela = relationshipAnzela + 1
    Но должна сказать, что это было приятно.
    ---***До скорого.
->END
=Path8
{agreementShare == 0: ->Path7 }
Что ещё? #portrait:1 #speaker:Анжела
* На данный момент, я не имею больше вопросов. #speaker:Саймон #portrait:3
В таком случае настала ваша очередь делится информацией. #portrait:1 #speaker:Анжела
* Хоть и произошло убийство, время прибывания здесь обещает быть одним из самых приятных. #speaker:Саймон #portrait:3
   Почему же?  #portrait:1 #speaker:Анжела
    ** Отдохну от городской суеты. #speaker:Саймон #portrait:3
    Как же я вас понимаю.#portrait:1 #speaker:Анжела
    ---***До скорого. ->END
    ** [Из-за вас.] Я проведу его с самой прекрасной дамой на свете.  #speaker:Саймон #portrait:3
    Я не из той категории девушек падких на лесть.#portrait:1 #speaker:Анжела
    ~relationshipAnzela = relationshipAnzela + 1
    Но должна сказать, что это было приятно.
    ---***До скорого.
    Не так быстро. Сдерживайте свои обещания. Я жду информацию. #portrait:1 #speaker:Анжела
- **** Что вас интересует? #speaker:Саймон #portrait:3
Почему вы расследуете это дело? Уверены, что это не несчастный случай? #portrait:1 #speaker:Анжела
** Я склонен считать, что бедолагу отравили. #speaker:Саймон #portrait:3
~poisoning = 1
***** Я не уверен, что это убийство. Просто хотел проверить все варианты. #speaker:Саймон #portrait:3
   Как он умер? #portrait:1 #speaker:Анжела
   ***Придерживаюсь варианта с отравлением. #speaker:Саймон #portrait:3
   ~poisoning = 1
   ****Придерживаюсь варианта, что он ударился головой при падении. #speaker:Саймон #portrait:3
->END
/*
* На этом всё. Досвидание. #speaker:Саймон #portrait:3
Не так быстро. Сдерживайте свои обещания. Я жду информацию. #portrait:1 #speaker:Анжела
- * Что вас интересует? #speaker:Саймон #portrait:3
Почему вы расследуете это дело? Уверены, что это не несчастный случай? #portrait:1 #speaker:Анжела
** Я склонен считать, что бедолагу отравили. #speaker:Саймон #portrait:3
~poisoning = 1
** Я не уверен, что это убийство. Просто хотел проверить все варианты. #speaker:Саймон #portrait:3
   Как он умер? #portrait:1 #speaker:Анжела
   ***Придерживаюсь варианта с отравлением. #speaker:Саймон #portrait:3
   ~poisoning = 1
   ***Придерживаюсь варианта, что он ударился головой при падении. #speaker:Саймон #portrait:3
   */
- -> Path9
=Path9
{!Уже есть подозреваемые| Кто ещё| Кто ещё | Кто ещё  Кто ещё } 
<>?#portrait:1 #speaker:Анжела
{ poisoning == 1:
*Повар мог отравить еду. #speaker:Саймон #portrait:3
->Path9
}
*Думаю, что с вас хватит. #speaker:Саймон #portrait:3
->Path7
*Вы. #speaker:Саймон #portrait:3
Это конечно обидно. Но одновременно и интересно. #portrait:1 #speaker:Анжела
**Я пошутил. #speaker:Саймон #portrait:3
->Path7
**Что есть, то есть. #speaker:Саймон #portrait:3
~relationshipAnzela = relationshipAnzela - 2
->Path7
{conversationSofia == 1: 
* София соврала об своём алиби и ведёт себя подозрительно->Path10
}
{conversationWilson == 1: 
* Вилсон - знакомый Мартина, утверждает, что пробыл в парке около часа->Path10
}
=Path10
.#speaker:Саймон #portrait:3
->Path9