INCLUDE globals.ink
->Main
VAR con1 = 0
===Main===
~ conversationWilson = 1
Вы хотели что-то от меня? #speaker:Вилсон #portrait:0
*Да, я хотел что бы вы ответили на несколько моих вопросов. #speaker:Саймон #portrait:1
Несколько вопросов? Что-то случилось? #speaker:Вилсон #portrait:0
->Path1
*Хорошо притворяетесь, что не виновны! #speaker:Саймон #portrait:1
Притворяюсь? #speaker:Вилсон #portrait:0
    **Извините, я вспылил и поступил не тактично. #speaker:Саймон #portrait:1
    ->Path1
    Бывает, так что произошло? #speaker:Вилсон #portrait:0
    **Да, не стройте из себя невинное дитя. #speaker:Саймон #portrait:1
    Да что вы себе позволяете! #speaker:Вилсон #portrait:0
    ->Path1
=Path1
...
*Сегодня один из постояльцев был найден мёртвым. #speaker:Саймон #portrait:1
Вы говорите о славном Журтэке или о ком-то другом? #speaker:Вилсон #portrait:0
**А о ком ещё? Или у вас тут много знакомых? #speaker:Саймон #portrait:1
Я не первый раз в этом месте - так что у меня тут есть знакомые. #speaker:Вилсон #portrait:0
->Path2
**Да, именно о нём. #speaker:Саймон #portrait:1
->Path2
**Да, о нём. Приношу свои соболезнования. #speaker:Саймон #portrait:1
->Path2
=Path2
О господи, какой ужас! #speaker:Вилсон #portrait:0
*Так что вы обязаны ответить на все мои вопросы. #speaker:Саймон #portrait:1
*Поэтому я прошу у вас помощи в расследовании. Вы можете помочь ответив на вопросы. #speaker:Саймон #portrait:1
- Я мог бы и не отвечать без адвоката, т.к. знаю свои права, но готов помочь. Скажите сначала почему я должен отвечать на ваши вопросы? Вы коп? #speaker:Вилсон #portrait:0
* Я знаменитый и всеми любимый детектив Саймон Брендль.[] Можно считать, что владелец всего этого нанял меня. # #speaker:Саймон #portrait:1
Да вы нарцисс. #speaker:Вилсон #portrait:0
* Я детектив Саймон Брендль. Можно считать, что владелец всего этого нанял меня. #speaker:Саймон #portrait:1
-Я вас понял. Спрашивайте. #speaker:Вилсон #portrait:0
->Path3
=Path3
...
*Как давно вы были знакомы с Мартином? #speaker:Саймон #portrait:1
Около года. Мы познакомились в суде. Понимаете, я работаю судьёй, а он был адвокатом. #speaker:Вилсон #portrait:0
    ** Каких людей он защищал? #speaker:Саймон #portrait:1
    Преступников. Обычных уголовников и  головорезов. #speaker:Вилсон #portrait:0
    ->Path3
*Расскажите где находились в течении этого дня. #speaker:Саймон #portrait:1
После плотного завтрака мне захотело посмотреть природу. Тут очень красивые пейзажи - рекомендую как найдётся свободная минутка прогуляться в окрестностях. #speaker:Вилсон #portrait:0
Так что с самого утра я был за территорией поместья, а примерно час назад вернулся и наведался в этот дворик.
    ->Path5
*Случайность ли ,то что вы оба оказались в этом месте? #speaker:Саймон #portrait:1
    Думаю, что да. #speaker:Вилсон #portrait:0
    ->Path3
*Как думаете, кто желал ему смерти? #speaker:Саймон #portrait:1
    У него не было врагов. Хотя кто-то мог затаить на него обиду в связи с его работой. #speaker:Вилсон #portrait:0
    ->Path3
+ -> Path4    
=Path4
*Спасибо за разговор. #speaker:Саймон #portrait:1
*Пока вы ответили на все мои вопросы. #speaker:Саймон #portrait:1
-Можете сказать как его убили? Он был добрым человек и не заслуживал ужасной смерти. #speaker:Вилсон #portrait:0
Наверное стоит уточнить, что в принципе не заслуживал её.
*Не думаю, что мне стоит распространятся об этом. #speaker:Саймон #portrait:1
...
** [Закончить разговор.]  Удачи.  #speaker:Вилсон #portrait:0
->END
*Всего скорее его отравили. Мучился он недолго. #speaker:Саймон #portrait:1
Спасибо. #speaker:Вилсон #portrait:0
** [Закончить разговор.]  Удачи.  #speaker:Вилсон #portrait:0
->END
=Path5
...
*Можете сказать кто посещал этот двор пока вы были здесь? #speaker:Саймон #portrait:1
{con1 == 0: Если кто-то и проходил, то я бы  не заметил: потому что задремал->Path6| Если кто-то и проходил, то я бы  не заметил->Path6}
~ con1 = 1
->Path5
*Вы не видели ничего подозрительного?  #speaker:Саймон #portrait:1
Нет, не думаю. #speaker:Вилсон #portrait:0
->Path5 
*Обратили ли вы внимание на открытое окно в комнате Журтэка? #speaker:Саймон #portrait:1
{ con1 == 0: Я задремал так что ничего не видел, а уж тем-более бы не стал обращать внимание на окна->Path6|  Я же задремал так что ничего не видел, а уж тем-более бы не стал обращать внимание на окна->Path6}
~ con1 = 1
->Path5
+->Path3
=Path6
 .#speaker:Вилсон #portrait:0
->Path5